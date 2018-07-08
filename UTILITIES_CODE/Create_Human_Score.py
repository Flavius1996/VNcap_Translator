import json
import codecs
import random
import os
import glob

'''
COCO5k VN utility-code:
    Create Json files for computing Human score
'''

################## EDIT FOLLOWING LINES TO MAKE CHANGE ###########
# Images directory
IMG_DIR = './COCO5k/Images_test/'
# Captions directory
CAP_DIR = './COCO5k/Captions_test_vntk/'
# Save into JSON file name
jsonfile_GT = './captions_COCO5k_138test_vntk_HumanScore_4cap_GT.json'
# Save 
jsonfile_pre = './captions_COCO5k_138test_vntk_HumanScore_1cap_predict.json'

# image file prefix
fprefix = "COCO5k_test_"
# Captions per image
nCaptions_per_Img = 5
# Min length of a caption
MinCapLength = 10
##################################################################

JSONDATA_GT = {}
JSONDATA_GT["info"] = {}
JSONDATA_GT["info"]["description"] = "This is a subset of MS COCO 2014 dataset contains: 4000 train images from COCO_train2014 + 138 test images from COCO_val2014. \
                                   This small dataset is created on purpose using for researching Vietnamese Image Captioning."
JSONDATA_GT["info"]["contributor"] = "Hoang Huu Tin - UIT"
JSONDATA_GT["info"]["date_created"] = "05/04/2018 (dd/MM/YYY)"

# Add type field for Evaluation Code
JSONDATA_GT["type"] = "captions"
JSONDATA_GT["licenses"] =  [{"url": "http://creativecommons.org/licenses/by-nc-sa/2.0/", "id": 1, "name": "Attribution-NonCommercial-ShareAlike License"}, {"url": "http://creativecommons.org/licenses/by-nc/2.0/", "id": 2, "name": "Attribution-NonCommercial License"}, {"url": "http://creativecommons.org/licenses/by-nc-nd/2.0/", "id": 3, "name": "Attribution-NonCommercial-NoDerivs License"}, {"url": "http://creativecommons.org/licenses/by/2.0/", "id": 4, "name": "Attribution License"}, {"url": "http://creativecommons.org/licenses/by-sa/2.0/", "id": 5, "name": "Attribution-ShareAlike License"}, {"url": "http://creativecommons.org/licenses/by-nd/2.0/", "id": 6, "name": "Attribution-NoDerivs License"}, {"url": "http://flickr.com/commons/usage/", "id": 7, "name": "No known copyright restrictions"}, {"url": "http://www.usa.gov/copyright.shtml", "id": 8, "name": "United States Government Work"}]

# Images List of Dict
    # "id"
    # "file_name"
JSONDATA_GT["images"] = []

# Annotations List of Dict
    # "image_id"
    # "caption"
JSONDATA_GT["annotations"] = []


JSONDATA_pre = []
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

    JSONDATA_GT["images"].append(image_dict)

    random_index = random.sample([0,1,2,3,4], 1)[0]

    
    for i in range(len(captions)):    
        if i == random_index:
            continue

        if len(captions[i]) < MinCapLength:
            print("ERROR caption length < {}".format(MinCapLength))
            print(lines)
            print(capfile)
            exit()

        ann_dict = {}
        ann_dict["id"] = CAPID
        ann_dict["image_id"] = imgid
        ann_dict["caption"] = captions[i]

        JSONDATA_GT["annotations"].append(ann_dict)

        CAPID += 1

    ann_dict = {}
    ann_dict["image_id"] = int(imgid)
    ann_dict["caption"] = captions[random_index]
    JSONDATA_pre.append(ann_dict)

# Randomly shuffle
random.shuffle(JSONDATA_GT["images"])
random.shuffle(JSONDATA_GT["annotations"])

# Save groundtruth json file (4 captions per image)
with codecs.open(jsonfile_GT, 'w', encoding='utf-8') as jFile:
    json.dump(JSONDATA_GT, jFile, ensure_ascii=False)

# Save predict json file (only 1 caption)
with codecs.open(jsonfile_pre, 'w', encoding='utf-8') as jFile:
    json.dump(JSONDATA_pre, jFile, ensure_ascii=False)

print("===== Total Groundtruth captions: {}".format(CAPID-1))
print("===== Total predict captions: {}".format(len(JSONDATA_pre)))
print("===== Total captions: {}".format(CAPID-1))
print("Done! Save Groundtruth (4 captions) to json file: {}".format(jsonfile_GT))
print("Done! Save predict (1 caption) to json file: {}".format(jsonfile_pre))
