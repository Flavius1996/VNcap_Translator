import json
import codecs
import random
import os
import glob

'''
COCO5k VN utility-code:
    Create JSON data file from captions folder
'''

################## EDIT FOLLOWING LINES TO MAKE CHANGE ###########
# Images directory
IMG_DIR = './COCO5k/Images_train/'
# Captions directory
CAP_DIR = './COCO5k/Captions_train_3000googlevn/'
# Save into JSON file name
jsonfile = './captions_COCO5k_train_3000googlevn.json'
# image file prefix
fprefix = "COCO5k_train_"
# Captions per image
nCaptions_per_Img = 5
# Min length of a caption
MinCapLength = 10
##################################################################

JSONDATA = {}
JSONDATA["info"] = {}
JSONDATA["info"]["description"] = "This is a subset of MS COCO 2014 dataset contains: 4000 train images from COCO_train2014 + 138 test images from COCO_val2014. \
                                   This small dataset is created on purpose using for researching Vietnamese Image Captioning."
JSONDATA["info"]["contributor"] = "Hoang Huu Tin - UIT"
JSONDATA["info"]["date_created"] = "05/04/2018 (dd/MM/YYY)"

# Add type field for Evaluation Code
JSONDATA["type"] = "captions"
JSONDATA["licenses"] =  [{"url": "http://creativecommons.org/licenses/by-nc-sa/2.0/", "id": 1, "name": "Attribution-NonCommercial-ShareAlike License"}, {"url": "http://creativecommons.org/licenses/by-nc/2.0/", "id": 2, "name": "Attribution-NonCommercial License"}, {"url": "http://creativecommons.org/licenses/by-nc-nd/2.0/", "id": 3, "name": "Attribution-NonCommercial-NoDerivs License"}, {"url": "http://creativecommons.org/licenses/by/2.0/", "id": 4, "name": "Attribution License"}, {"url": "http://creativecommons.org/licenses/by-sa/2.0/", "id": 5, "name": "Attribution-ShareAlike License"}, {"url": "http://creativecommons.org/licenses/by-nd/2.0/", "id": 6, "name": "Attribution-NoDerivs License"}, {"url": "http://flickr.com/commons/usage/", "id": 7, "name": "No known copyright restrictions"}, {"url": "http://www.usa.gov/copyright.shtml", "id": 8, "name": "United States Government Work"}]

# Images List of Dict
    # "id"
    # "file_name"
JSONDATA["images"] = []

# Annotations List of Dict
    # "image_id"
    # "caption"
JSONDATA["annotations"] = []

# Fake Caption ID for Evalutation Code
CAPID = 1

capfilepaths = glob.glob(CAP_DIR + "*")
imgfilepaths = glob.glob(IMG_DIR + "*")

imgfilenames = [os.path.basename(x) for x in imgfilepaths]

print("===== Total files: {}".format(len(capfilepaths)))

for capfile in capfilepaths:
    with open(capfile, 'r', encoding='utf8') as f:
        lines = [x.strip() for x in f.readlines()]

    imgid = int(lines[0])
    captions = lines[1:]
    if len(captions) != nCaptions_per_Img:
        print("ERROR number of captions != {}".format(nCaptions_per_Img))
        print(lines)
        print(capfile)
        exit()

    # Check exist image file
    
    fid = "{:012}".format(imgid)
    filename = fprefix + fid + '.jpg'

    assert (filename in imgfilenames)

    # Check name of caption file with its ID in context
    assert (fid in os.path.basename(capfile))


    image_dict = {}
    image_dict["id"] = imgid
    image_dict["file_name"] = filename

    JSONDATA["images"].append(image_dict)

    for cap in captions:    
        if len(cap) < MinCapLength:
            print("ERROR caption length < {}".format(MinCapLength))
            print(lines)
            print(capfile)
            exit()

        ann_dict = {}
        ann_dict["id"] = CAPID
        ann_dict["image_id"] = imgid
        ann_dict["caption"] = cap

        JSONDATA["annotations"].append(ann_dict)

        CAPID += 1


# Randomly shuffle
random.shuffle(JSONDATA["images"])
random.shuffle(JSONDATA["annotations"])

with codecs.open(jsonfile, 'w', encoding='utf-8') as jFile:
    json.dump(JSONDATA, jFile, ensure_ascii=False)

print("===== Total captions: {}".format(CAPID-1))
print("Done! Save to json file: {}".format(jsonfile))