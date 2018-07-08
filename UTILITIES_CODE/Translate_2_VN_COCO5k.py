import shutil
import os
import glob
import time

from googletrans import Translator
translator = Translator()

# import goslate
# gs = goslate.Goslate()

'''
Google Translate from English captions from Captions folder into Vietnamese
'''

IMG_DIR = './COCOvn/Images_train/'
ENCAP_DIR = './COCOvn/Captions_train_en/'
DSTCAP_DIR = './COCOvn/Captions_train_googlevn/'

IMGFILE_PREFIX = "COCO5k_train_"
SUFFIX = '_googlevn.txt'

# if os.path.exists(DSTCAP_DIR):
#     shutil.rmtree(DSTCAP_DIR)
#     os.mkdir(DSTCAP_DIR)
# else:
#     os.mkdir(DSTCAP_DIR)

capfilepaths = glob.glob(ENCAP_DIR + "*")
imgfilepaths = glob.glob(IMG_DIR + "*.jpg")

imgfilenames = [os.path.basename(x) for x in imgfilepaths]


for c in range(0, len(capfilepaths)):
    capfile = capfilepaths[c]

    with open(capfile, 'r', encoding='utf8') as f:
        lines = [x.strip() for x in f.readlines()]

    imgid = int(lines[0])
    captions = lines[1:]

    # Check number of captions in file
    if len(captions) != 5:
        print("ERROR number of captions != 5")
        print(lines)
        print(capfile)
        exit()

    # Check exist image file
    
    fid = "{:012}".format(imgid)

    filename = IMGFILE_PREFIX + fid + '.jpg'

    assert (filename in imgfilenames)

    fname = os.path.splitext(filename)[0]
    dest_filename = fname + SUFFIX

    lastcap = ""
    with open(DSTCAP_DIR + dest_filename, 'w', encoding='utf-8') as file:
        # format id
        #id_s = "{:08}".format(imgid)

        file.write(str(imgid))
        for cap in captions:
            # Lower Caption
            cap = cap.lower()

            # Google Translate Caption
            cap = translator.translate(cap, dest='vi').text
            # cap = gs.translate(cap, 'vi')
            # time.sleep(0.03)


            # Normalize cap
            cap = cap.strip()
            if (cap[-1] == '.'):
                cap = cap[:-1]
            
            if len(cap) < 10:
                print("ERROR cap length < 10")
                print(cap)
                print(dest_filename)
                exit()

            file.write('\n' + cap.strip())

            lastcap = cap

    # if c % 20 == 0:
    print("[{}/{}] Write file: {}".format(c, len(capfilepaths), dest_filename))
    print(lastcap)