namespace VNcap_Annotator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.split_full = new System.Windows.Forms.SplitContainer();
            this.capVNCount_lb = new System.Windows.Forms.Label();
            this.capENCount_lb = new System.Windows.Forms.Label();
            this.imgCount_lb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.capdir_txt = new System.Windows.Forms.TextBox();
            this.imgdir_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.split_1 = new System.Windows.Forms.SplitContainer();
            this.img_Listbox = new System.Windows.Forms.ListBox();
            this.split_2 = new System.Windows.Forms.SplitContainer();
            this.next_btn = new System.Windows.Forms.Button();
            this.prev_btn = new System.Windows.Forms.Button();
            this.picture_main = new System.Windows.Forms.PictureBox();
            this.google_btn = new System.Windows.Forms.Button();
            this.cap5_txt_en = new System.Windows.Forms.TextBox();
            this.cap4_txt_en = new System.Windows.Forms.TextBox();
            this.cap3_txt_en = new System.Windows.Forms.TextBox();
            this.cap2_txt_en = new System.Windows.Forms.TextBox();
            this.cap1_txt_en = new System.Windows.Forms.TextBox();
            this.imgID_lb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.cap5_txt = new System.Windows.Forms.TextBox();
            this.cap4_txt = new System.Windows.Forms.TextBox();
            this.cap3_txt = new System.Windows.Forms.TextBox();
            this.cap2_txt = new System.Windows.Forms.TextBox();
            this.cap1_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.split_full)).BeginInit();
            this.split_full.Panel1.SuspendLayout();
            this.split_full.Panel2.SuspendLayout();
            this.split_full.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split_1)).BeginInit();
            this.split_1.Panel1.SuspendLayout();
            this.split_1.Panel2.SuspendLayout();
            this.split_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_2)).BeginInit();
            this.split_2.Panel1.SuspendLayout();
            this.split_2.Panel2.SuspendLayout();
            this.split_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_main)).BeginInit();
            this.SuspendLayout();
            // 
            // split_full
            // 
            this.split_full.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_full.Location = new System.Drawing.Point(0, 0);
            this.split_full.Name = "split_full";
            this.split_full.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split_full.Panel1
            // 
            this.split_full.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.split_full.Panel1.Controls.Add(this.capVNCount_lb);
            this.split_full.Panel1.Controls.Add(this.capENCount_lb);
            this.split_full.Panel1.Controls.Add(this.imgCount_lb);
            this.split_full.Panel1.Controls.Add(this.pictureBox1);
            this.split_full.Panel1.Controls.Add(this.capdir_txt);
            this.split_full.Panel1.Controls.Add(this.imgdir_txt);
            this.split_full.Panel1.Controls.Add(this.label2);
            this.split_full.Panel1.Controls.Add(this.label1);
            // 
            // split_full.Panel2
            // 
            this.split_full.Panel2.Controls.Add(this.split_1);
            this.split_full.Size = new System.Drawing.Size(1262, 673);
            this.split_full.SplitterDistance = 91;
            this.split_full.TabIndex = 0;
            // 
            // capVNCount_lb
            // 
            this.capVNCount_lb.AutoSize = true;
            this.capVNCount_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capVNCount_lb.ForeColor = System.Drawing.Color.SeaGreen;
            this.capVNCount_lb.Location = new System.Drawing.Point(922, 41);
            this.capVNCount_lb.Name = "capVNCount_lb";
            this.capVNCount_lb.Size = new System.Drawing.Size(110, 18);
            this.capVNCount_lb.TabIndex = 7;
            this.capVNCount_lb.Text = "0 VN caption(s)";
            // 
            // capENCount_lb
            // 
            this.capENCount_lb.AutoSize = true;
            this.capENCount_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capENCount_lb.ForeColor = System.Drawing.Color.SeaGreen;
            this.capENCount_lb.Location = new System.Drawing.Point(922, 61);
            this.capENCount_lb.Name = "capENCount_lb";
            this.capENCount_lb.Size = new System.Drawing.Size(111, 18);
            this.capENCount_lb.TabIndex = 6;
            this.capENCount_lb.Text = "0 EN caption(s)";
            // 
            // imgCount_lb
            // 
            this.imgCount_lb.AutoSize = true;
            this.imgCount_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgCount_lb.ForeColor = System.Drawing.Color.SeaGreen;
            this.imgCount_lb.Location = new System.Drawing.Point(922, 20);
            this.imgCount_lb.Name = "imgCount_lb";
            this.imgCount_lb.Size = new System.Drawing.Size(78, 18);
            this.imgCount_lb.TabIndex = 5;
            this.imgCount_lb.Text = "0 image(s)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::VNcap_Annotator.Properties.Resources.UIT31;
            this.pictureBox1.Location = new System.Drawing.Point(1073, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // capdir_txt
            // 
            this.capdir_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capdir_txt.Location = new System.Drawing.Point(120, 51);
            this.capdir_txt.Name = "capdir_txt";
            this.capdir_txt.ReadOnly = true;
            this.capdir_txt.Size = new System.Drawing.Size(784, 24);
            this.capdir_txt.TabIndex = 3;
            this.capdir_txt.Text = "Vietnamese Captions will be saved Here";
            // 
            // imgdir_txt
            // 
            this.imgdir_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgdir_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgdir_txt.Location = new System.Drawing.Point(120, 19);
            this.imgdir_txt.Name = "imgdir_txt";
            this.imgdir_txt.ReadOnly = true;
            this.imgdir_txt.Size = new System.Drawing.Size(784, 24);
            this.imgdir_txt.TabIndex = 2;
            this.imgdir_txt.Text = "Select Images Directory";
            this.imgdir_txt.Click += new System.EventHandler(this.imgdir_txt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Captions Dir:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Images Dir:";
            // 
            // split_1
            // 
            this.split_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_1.Location = new System.Drawing.Point(0, 0);
            this.split_1.Name = "split_1";
            // 
            // split_1.Panel1
            // 
            this.split_1.Panel1.Controls.Add(this.img_Listbox);
            // 
            // split_1.Panel2
            // 
            this.split_1.Panel2.Controls.Add(this.split_2);
            this.split_1.Size = new System.Drawing.Size(1262, 578);
            this.split_1.SplitterDistance = 239;
            this.split_1.TabIndex = 0;
            // 
            // img_Listbox
            // 
            this.img_Listbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_Listbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.img_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.img_Listbox.FormattingEnabled = true;
            this.img_Listbox.ItemHeight = 20;
            this.img_Listbox.Items.AddRange(new object[] {
            "Images filename list"});
            this.img_Listbox.Location = new System.Drawing.Point(0, 0);
            this.img_Listbox.Name = "img_Listbox";
            this.img_Listbox.Size = new System.Drawing.Size(235, 574);
            this.img_Listbox.TabIndex = 0;
            this.img_Listbox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.img_Listbox_DrawItem);
            this.img_Listbox.SelectedIndexChanged += new System.EventHandler(this.img_Listbox_SelectedIndexChanged);
            // 
            // split_2
            // 
            this.split_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_2.Location = new System.Drawing.Point(0, 0);
            this.split_2.Name = "split_2";
            // 
            // split_2.Panel1
            // 
            this.split_2.Panel1.Controls.Add(this.next_btn);
            this.split_2.Panel1.Controls.Add(this.prev_btn);
            this.split_2.Panel1.Controls.Add(this.picture_main);
            // 
            // split_2.Panel2
            // 
            this.split_2.Panel2.Controls.Add(this.google_btn);
            this.split_2.Panel2.Controls.Add(this.cap5_txt_en);
            this.split_2.Panel2.Controls.Add(this.cap4_txt_en);
            this.split_2.Panel2.Controls.Add(this.cap3_txt_en);
            this.split_2.Panel2.Controls.Add(this.cap2_txt_en);
            this.split_2.Panel2.Controls.Add(this.cap1_txt_en);
            this.split_2.Panel2.Controls.Add(this.imgID_lb);
            this.split_2.Panel2.Controls.Add(this.label8);
            this.split_2.Panel2.Controls.Add(this.save_btn);
            this.split_2.Panel2.Controls.Add(this.cap5_txt);
            this.split_2.Panel2.Controls.Add(this.cap4_txt);
            this.split_2.Panel2.Controls.Add(this.cap3_txt);
            this.split_2.Panel2.Controls.Add(this.cap2_txt);
            this.split_2.Panel2.Controls.Add(this.cap1_txt);
            this.split_2.Panel2.Controls.Add(this.label7);
            this.split_2.Panel2.Controls.Add(this.label5);
            this.split_2.Panel2.Controls.Add(this.label6);
            this.split_2.Panel2.Controls.Add(this.label4);
            this.split_2.Panel2.Controls.Add(this.label3);
            this.split_2.Size = new System.Drawing.Size(1019, 578);
            this.split_2.SplitterDistance = 497;
            this.split_2.TabIndex = 0;
            // 
            // next_btn
            // 
            this.next_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.Location = new System.Drawing.Point(300, 518);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(108, 46);
            this.next_btn.TabIndex = 2;
            this.next_btn.Text = ">>";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prev_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_btn.Location = new System.Drawing.Point(70, 518);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(108, 46);
            this.prev_btn.TabIndex = 1;
            this.prev_btn.Text = "<<";
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // picture_main
            // 
            this.picture_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_main.BackColor = System.Drawing.SystemColors.Info;
            this.picture_main.Image = global::VNcap_Annotator.Properties.Resources.UIT31;
            this.picture_main.Location = new System.Drawing.Point(3, 3);
            this.picture_main.Name = "picture_main";
            this.picture_main.Size = new System.Drawing.Size(487, 491);
            this.picture_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_main.TabIndex = 0;
            this.picture_main.TabStop = false;
            // 
            // google_btn
            // 
            this.google_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.google_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.google_btn.Location = new System.Drawing.Point(415, 10);
            this.google_btn.Name = "google_btn";
            this.google_btn.Size = new System.Drawing.Size(90, 40);
            this.google_btn.TabIndex = 18;
            this.google_btn.Text = "Google";
            this.google_btn.UseVisualStyleBackColor = false;
            this.google_btn.Click += new System.EventHandler(this.google_btn_Click);
            // 
            // cap5_txt_en
            // 
            this.cap5_txt_en.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cap5_txt_en.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cap5_txt_en.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap5_txt_en.Location = new System.Drawing.Point(108, 411);
            this.cap5_txt_en.Name = "cap5_txt_en";
            this.cap5_txt_en.ReadOnly = true;
            this.cap5_txt_en.Size = new System.Drawing.Size(397, 24);
            this.cap5_txt_en.TabIndex = 17;
            // 
            // cap4_txt_en
            // 
            this.cap4_txt_en.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cap4_txt_en.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cap4_txt_en.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap4_txt_en.Location = new System.Drawing.Point(108, 327);
            this.cap4_txt_en.Name = "cap4_txt_en";
            this.cap4_txt_en.ReadOnly = true;
            this.cap4_txt_en.Size = new System.Drawing.Size(397, 24);
            this.cap4_txt_en.TabIndex = 16;
            // 
            // cap3_txt_en
            // 
            this.cap3_txt_en.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cap3_txt_en.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cap3_txt_en.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap3_txt_en.Location = new System.Drawing.Point(108, 234);
            this.cap3_txt_en.Name = "cap3_txt_en";
            this.cap3_txt_en.ReadOnly = true;
            this.cap3_txt_en.Size = new System.Drawing.Size(397, 24);
            this.cap3_txt_en.TabIndex = 15;
            // 
            // cap2_txt_en
            // 
            this.cap2_txt_en.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cap2_txt_en.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cap2_txt_en.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap2_txt_en.Location = new System.Drawing.Point(108, 145);
            this.cap2_txt_en.Name = "cap2_txt_en";
            this.cap2_txt_en.ReadOnly = true;
            this.cap2_txt_en.Size = new System.Drawing.Size(397, 24);
            this.cap2_txt_en.TabIndex = 14;
            // 
            // cap1_txt_en
            // 
            this.cap1_txt_en.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cap1_txt_en.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cap1_txt_en.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap1_txt_en.Location = new System.Drawing.Point(108, 56);
            this.cap1_txt_en.Name = "cap1_txt_en";
            this.cap1_txt_en.ReadOnly = true;
            this.cap1_txt_en.Size = new System.Drawing.Size(397, 24);
            this.cap1_txt_en.TabIndex = 13;
            // 
            // imgID_lb
            // 
            this.imgID_lb.AutoSize = true;
            this.imgID_lb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgID_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgID_lb.ForeColor = System.Drawing.Color.Blue;
            this.imgID_lb.Location = new System.Drawing.Point(125, 19);
            this.imgID_lb.Name = "imgID_lb";
            this.imgID_lb.Size = new System.Drawing.Size(99, 31);
            this.imgID_lb.TabIndex = 12;
            this.imgID_lb.Text = "000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Image ID:";
            // 
            // save_btn
            // 
            this.save_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.save_btn.Location = new System.Drawing.Point(205, 500);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(140, 44);
            this.save_btn.TabIndex = 10;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cap5_txt
            // 
            this.cap5_txt.AllowDrop = true;
            this.cap5_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cap5_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap5_txt.Location = new System.Drawing.Point(19, 441);
            this.cap5_txt.Multiline = true;
            this.cap5_txt.Name = "cap5_txt";
            this.cap5_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cap5_txt.Size = new System.Drawing.Size(486, 53);
            this.cap5_txt.TabIndex = 9;
            this.cap5_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cap1_txt_KeyPress);
            // 
            // cap4_txt
            // 
            this.cap4_txt.AllowDrop = true;
            this.cap4_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cap4_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap4_txt.Location = new System.Drawing.Point(19, 355);
            this.cap4_txt.Multiline = true;
            this.cap4_txt.Name = "cap4_txt";
            this.cap4_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cap4_txt.Size = new System.Drawing.Size(486, 53);
            this.cap4_txt.TabIndex = 8;
            this.cap4_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cap1_txt_KeyPress);
            // 
            // cap3_txt
            // 
            this.cap3_txt.AllowDrop = true;
            this.cap3_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cap3_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap3_txt.Location = new System.Drawing.Point(19, 262);
            this.cap3_txt.Multiline = true;
            this.cap3_txt.Name = "cap3_txt";
            this.cap3_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cap3_txt.Size = new System.Drawing.Size(486, 53);
            this.cap3_txt.TabIndex = 7;
            this.cap3_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cap1_txt_KeyPress);
            // 
            // cap2_txt
            // 
            this.cap2_txt.AllowDrop = true;
            this.cap2_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cap2_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap2_txt.Location = new System.Drawing.Point(19, 173);
            this.cap2_txt.Multiline = true;
            this.cap2_txt.Name = "cap2_txt";
            this.cap2_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cap2_txt.Size = new System.Drawing.Size(486, 53);
            this.cap2_txt.TabIndex = 6;
            this.cap2_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cap1_txt_KeyPress);
            // 
            // cap1_txt
            // 
            this.cap1_txt.AllowDrop = true;
            this.cap1_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cap1_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap1_txt.Location = new System.Drawing.Point(19, 85);
            this.cap1_txt.Multiline = true;
            this.cap1_txt.Name = "cap1_txt";
            this.cap1_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cap1_txt.Size = new System.Drawing.Size(486, 53);
            this.cap1_txt.TabIndex = 5;
            this.cap1_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cap1_txt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Caption 5:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Caption 4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Caption 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Caption 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Caption 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.split_full);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VNcap Translator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.split_full.Panel1.ResumeLayout(false);
            this.split_full.Panel1.PerformLayout();
            this.split_full.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_full)).EndInit();
            this.split_full.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.split_1.Panel1.ResumeLayout(false);
            this.split_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_1)).EndInit();
            this.split_1.ResumeLayout(false);
            this.split_2.Panel1.ResumeLayout(false);
            this.split_2.Panel2.ResumeLayout(false);
            this.split_2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_2)).EndInit();
            this.split_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split_full;
        private System.Windows.Forms.SplitContainer split_1;
        private System.Windows.Forms.SplitContainer split_2;
        private System.Windows.Forms.TextBox capdir_txt;
        private System.Windows.Forms.TextBox imgdir_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox img_Listbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cap1_txt;
        private System.Windows.Forms.TextBox cap5_txt;
        private System.Windows.Forms.TextBox cap4_txt;
        private System.Windows.Forms.TextBox cap3_txt;
        private System.Windows.Forms.TextBox cap2_txt;
        private System.Windows.Forms.PictureBox picture_main;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label imgCount_lb;
        private System.Windows.Forms.Label capENCount_lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label imgID_lb;
        private System.Windows.Forms.TextBox cap5_txt_en;
        private System.Windows.Forms.TextBox cap4_txt_en;
        private System.Windows.Forms.TextBox cap3_txt_en;
        private System.Windows.Forms.TextBox cap2_txt_en;
        private System.Windows.Forms.TextBox cap1_txt_en;
        private System.Windows.Forms.Button google_btn;
        private System.Windows.Forms.Label capVNCount_lb;
    }
}

