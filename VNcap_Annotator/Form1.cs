using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VNcap_Annotator
{
    public partial class Form1 : Form
    {
        /// ############## GLOBAL VARIABLES #############
        // Images directory path
        private string IMGDIR_str = "";
        // Captions directory path
        private string CAPDIR_str = "";
        // Images filename list
        public List<string> IMG_list = new List<string>();
        // English Captions filename list
        public List<string> CAP_list_EN = new List<string>();
        // Vietnamese Captions filename list
        public List<string> CAP_list_VN = new List<string>();

        // First time click Google
        private bool bFirstClickGoogle = true;
        private bool bFirstClickListBox = true;
        private bool bAlwayGoogle = false;

        // Caption 1->5 string
        //public string CAP1_str, CAP2_str, CAP3_str, CAP4_str, CAP5_str;
        private TextBox[] CAP_TEXTBOXES;

        // caption textboxes in English
        private TextBox[] CAP_TEXTBOXES_EN;

        // Save Vietnamese caption
        string CaptionVN_path = "./Captions_train_vn";

        /// #############################################

        public Form1()
        {
            InitializeComponent();
            CAP_TEXTBOXES = new TextBox[] { cap1_txt, cap2_txt, cap3_txt, cap4_txt, cap5_txt };
            CAP_TEXTBOXES_EN = new TextBox[] { cap1_txt_en, cap2_txt_en, cap3_txt_en, cap4_txt_en, cap5_txt_en };
            next_btn.Enabled = false;
            prev_btn.Enabled = false;
            save_btn.Enabled = false;
            google_btn.Enabled = false;
            img_Listbox.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void imgdir_txt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Directory.GetCurrentDirectory();

            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                IMGDIR_str = fbd.SelectedPath;
                string[] imgfiles = Directory.GetFiles(fbd.SelectedPath, "*.jpg");
                foreach (string file in imgfiles)
                {
                    IMG_list.Add(Path.GetFileName(file));
                }
                // Update label
                imgdir_txt.Text = IMGDIR_str;
                imgCount_lb.Text = IMG_list.Count().ToString() + " image(s)";

                // Update images Listbox
                if (IMG_list.Count() > 0)
                {
                    img_Listbox.Enabled = true;
                    // Reset listbox
                    img_Listbox.Items.Clear();
                    // Add new filename
                    foreach (string file in IMG_list)
                    {
                        img_Listbox.Items.Add(file);
                    }
                }

                CAPDIR_str = fbd.SelectedPath;
                string[] capfiles = Directory.GetFiles(fbd.SelectedPath, "*_en.txt");
                foreach (string file in capfiles)
                {
                    CAP_list_EN.Add(Path.GetFileNameWithoutExtension(file));
                }
                // Update label
                capENCount_lb.Text = capfiles.Count().ToString() + " EN caption(s)";

                // Set Caption Vietnamese path
                CaptionVN_path = Directory.GetCurrentDirectory() + "\\" + Path.GetFileName(fbd.SelectedPath) + "_TransVN";
                Directory.CreateDirectory(CaptionVN_path);

                string[] files = Directory.GetFiles(CaptionVN_path, "*_vn.txt");
                foreach (string file in files)
                {
                    CAP_list_VN.Add(Path.GetFileNameWithoutExtension(file));
                }
                capdir_txt.Text = CaptionVN_path;
                capVNCount_lb.Text = CAP_list_VN.Count().ToString() + " VN caption(s)";

                // Update images Listbox
                if (CAP_list_VN.Count() > 0)
                    img_Listbox.Refresh();
            }
        }

        private void img_Listbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Color green for images which already have caption file
            e.DrawBackground();
            e.DrawFocusRectangle();
        
            SolidBrush full5caption_Brush = new SolidBrush(Color.Green);
            SolidBrush captionexist_Brush = new SolidBrush(Color.Gold);
            Font captionexist_Font = new Font(e.Font, FontStyle.Bold);
            Color defaultColor = Color.Black;

            string imgfilename = Path.GetFileNameWithoutExtension(this.img_Listbox.Items[e.Index].ToString());

            if (CAP_list_VN.Contains(imgfilename + "_vn"))
            {
                string capfilepath = CaptionVN_path + '\\' + imgfilename + "_vn.txt";
                // Check if caption is full 5-caption -> green color; else -> yellow color
                if (checkCaptionFile(capfilepath))
                    e.Graphics.DrawString(this.img_Listbox.Items[e.Index].ToString(), captionexist_Font, full5caption_Brush, e.Bounds);
                else
                    e.Graphics.DrawString(this.img_Listbox.Items[e.Index].ToString(), captionexist_Font, captionexist_Brush, e.Bounds);
            }
            else
                e.Graphics.DrawString(this.img_Listbox.Items[e.Index].ToString(), this.img_Listbox.Font, new SolidBrush(defaultColor), e.Bounds);
        }

        private void img_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bFirstClickListBox)
            {
                next_btn.Enabled = true;
                prev_btn.Enabled = true;
                save_btn.Enabled = true;
                google_btn.Enabled = true;
                bFirstClickListBox = false;
            }
            // Show image
            string img_filename = img_Listbox.SelectedItem.ToString();
            string img_filepath = IMGDIR_str + '\\' + img_filename;
            this.picture_main.Image = Image.FromFile(img_filepath);

            // Check filename, filename must has format: <DATASETNAME>_<IMAGE_ID> 
            //              (atleast 1 symbol '_' in filename and imageid at the end of filename)
            string[] filename_split = Path.GetFileNameWithoutExtension(img_filename).Split('_');
            string img_id = "";
            if (filename_split.Count() > 0)
                img_id = filename_split[filename_split.Length - 1];
            bool isNumeric = int.TryParse(img_id, out int n);
            if ((filename_split.Count() == 0) || (isNumeric == false))
            {
                MessageBox.Show("Invalid image filename: " + img_filename, "ERROR!",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                return;
            }
            else
                // Set image id label
                imgID_lb.Text = img_id;

            // If English caption exist then show caption
            if (CAP_list_EN.Contains(Path.GetFileNameWithoutExtension(img_filename) + "_en"))
            {
                string capfilepath = CAPDIR_str + '\\' + Path.GetFileNameWithoutExtension(img_filename) + "_en.txt";
                string[] lines = System.IO.File.ReadAllLines(capfilepath);
                int count = 0;
                // Reset caption textbox
                foreach (TextBox tb in CAP_TEXTBOXES_EN)
                    tb.Text = "";
                foreach (string line in lines)
                {
                    if (count == 0)
                        // Ingore first image id line 
                        count++;
                    else
                    {
                        CAP_TEXTBOXES_EN[count-1].Text = line;
                        count++;
                    }
                }
            }
            else
            {
                // Not caption exist -> empty
                foreach (TextBox tb in CAP_TEXTBOXES_EN)
                    tb.Text = "";
            }

            if (bAlwayGoogle)
            {
                google_btn_Click(this, new EventArgs()); 
            }

            // If Vietnamese caption exist then show caption
            if (CAP_list_VN.Contains(Path.GetFileNameWithoutExtension(img_filename) + "_vn"))
            {
                string capfilepath = CaptionVN_path + '\\' + Path.GetFileNameWithoutExtension(img_filename) + "_vn.txt";
                string[] lines = System.IO.File.ReadAllLines(capfilepath);
                int count = 0;
                // Reset caption textbox
                foreach (TextBox tb in CAP_TEXTBOXES)
                    tb.Text = "";
                foreach (string line in lines)
                {
                    if (count == 0)
                        // Ingore first image id line 
                        count++;
                    else
                    {
                        CAP_TEXTBOXES[count - 1].Text = line;
                        count++;
                    }
                }
            }
            else
            {
                if (!bAlwayGoogle)
                {
                    // Not caption exist -> empty
                    foreach (TextBox tb in CAP_TEXTBOXES)
                        tb.Text = "";
                }
            }
        }

        /// #################################################
        /// ################ BUTTON HANDLES #################
        /// #################################################
        private void next_btn_Click(object sender, EventArgs e)
        {
            if (this.img_Listbox.SelectedIndex < this.img_Listbox.Items.Count - 1)
                this.img_Listbox.SelectedIndex++;
            else if (this.img_Listbox.SelectedIndex == this.img_Listbox.Items.Count - 1)
                this.img_Listbox.SelectedIndex = 0;
        }
        private void prev_btn_Click(object sender, EventArgs e)
        {
            if (this.img_Listbox.SelectedIndex > 0)
                this.img_Listbox.SelectedIndex--;
            else if (this.img_Listbox.SelectedIndex == 0)
                this.img_Listbox.SelectedIndex = this.img_Listbox.Items.Count - 1;
        }

        private void google_btn_Click(object sender, EventArgs e)
        {
            if (bFirstClickGoogle)
            {
                MessageBox.Show("WARNING!\nThis function will use Google Translate as a reference source for these captions. \nThe Human translation must be natural, fluent and perfect in grammar. \nDO NOT OVERUSE this function, thank you!", "First time click Google!",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                bFirstClickGoogle = false;
            }
            string img_filename = img_Listbox.SelectedItem.ToString();
            string googlevn_filename = Path.GetFileNameWithoutExtension(img_filename) + "_googlevn.txt";
            string googlevn_filepath = CAPDIR_str + '\\' + googlevn_filename;
            if (!File.Exists(googlevn_filepath))
            {
                MessageBox.Show("Can't find Google translation for this image.", "ERROR",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                return;
            }

            string[] lines = System.IO.File.ReadAllLines(googlevn_filepath);
            int count = 0;
            // Reset caption textbox
            foreach (TextBox tb in CAP_TEXTBOXES)
                tb.Text = "";
            foreach (string line in lines)
            {
                if (count == 0)
                    // Ingore first image id line 
                    count++;
                else
                {
                    CAP_TEXTBOXES[count - 1].Text = line;
                    count++;
                }
            }

        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (bAlwayGoogle == false)
            {
                bAlwayGoogle = true;
                MessageBox.Show("You've just discovered the Secret Feature!\nThis will always set Google Translate turn on.\nFor turning it off, just double click this again.", "SECRET FEATURE",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You've just turned off the Secret Feature!", "SECRET FEATURE",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                bAlwayGoogle = false;
            }
        }
        /// <summary>
        /// Save captions into file .txt
        /// Caption file format:
        ///     #<Image integer ID>
        ///     <caption 1>
        ///     <caption 2>
        ///     <caption 3>
        ///     <caption 4>
        ///     <caption 5>
        /// </summary>
        private void save_btn_Click(object sender, EventArgs e)
        {
            // Check if CAPTION DIRECTORY is selected
            if (CAPDIR_str.Length == 0)
            {
                MessageBox.Show("Please select Caption Directory!", "WARNING!",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                return;
            }

            // Check filename, filename must has format: <DATASETNAME>_<IMAGE_ID> 
            //              (atleast 1 symbol '_' in filename and imageid at the end of filename)

            int img_id = Int32.Parse(imgID_lb.Text);
            string img_filename = Path.GetFileNameWithoutExtension(img_Listbox.SelectedItem.ToString());

            // Check caption texts
            foreach (TextBox tb in CAP_TEXTBOXES)
                if (!checkCaption(tb.Text))
                    return;

            string save_capfilename = img_filename + "_vn.txt";
            string save_capfilepath = CaptionVN_path + '\\' + save_capfilename;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(save_capfilepath))
            {
                // First line is Image ID
                file.Write(img_id);
                // Following lines are captions
                foreach (TextBox tb in CAP_TEXTBOXES)
                    if (tb.Text.Length > 0)
                        file.Write("\r\n" + tb.Text.Trim());
            }

            CAP_list_VN.Add(img_filename + "_vn");
            this.img_Listbox.Refresh();

            // Update caption count
            capVNCount_lb.Text = CAP_list_VN.Count().ToString() + " VN caption(s)";

            // Next picture
            this.next_btn_Click(this, new EventArgs());

            this.ActiveControl = cap1_txt;
        }
        private void cap1_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
        /// #################################################
        /// ############# UTILITY FUNCTIONS #################
        /// #################################################
        private bool checkCaption(string cap)
        {
            // A suitable caption's length from 30->300 characters
            int minChar = 20;
            int maxChar = 300;

            // Allow caption is empty -> empty caption will not be saved to caption txt file
            if (cap.Length == 0)
                return true;
            if ((cap.Length < minChar) || (cap.Length > maxChar))
            {
                MessageBox.Show("Invalid caption: \"" + cap +"\" \nA Caption must has " + minChar.ToString() + "->" + maxChar.ToString() + " characters.", "ERROR",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool checkCaptionFile(string capfilepath)
        {
            // Check if caption file is full 5 captions ( <=> 6 lines = 1 ID line + 5 caption lines )
            string[] lines = System.IO.File.ReadAllLines(capfilepath);
            if (lines.Count() == 6)
                return true;
            return false;
        }
        public void Show_MessageBox(string message, string caption)
        {
            MessageBox.Show(message, caption,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
        }

       
    }
}
