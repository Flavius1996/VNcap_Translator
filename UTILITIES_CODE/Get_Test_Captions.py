import shutil
import json
import io
import os
import glob

'''
Get Test Captions for Manually Selected Test images folder
'''

IMG_DIR = './COCO5k/Images_test/'

capDST_DIR = './COCO5k/Captions_test_vn/'

jsonfile = './annotations/captions_val2014.json'


### PREPARING FOLDERS
# Delete old data
if os.path.exists(capDST_DIR):
    shutil.rmtree(capDST_DIR)
    os.mkdir(capDST_DIR)
else:
    os.mkdir(capDST_DIR)

with io.open(jsonfile, 'r', encoding='utf-8') as f:
    jsondata = json.load(f)

# Get all test images filenames
IMG_FILENAMES = [os.path.basename(x) for x in glob.glob(IMG_DIR + "*.jpg")]
IMG_IDS = [os.path.splitext(x)[0].split('_')[-1] for x in IMG_FILENAMES]
IMG_IDS_int = [int(x) for x in IMG_IDS]

print('[D] filename:', IMG_FILENAMES[0])
print('[D] ID:', IMG_IDS[0])
print('[D] ID int:', IMG_IDS_int[0])

print('=' * 40)
print('Getting imgid_to_captions dict...')
numCaps = 0
imgid_to_captions = {}
for annotation in jsondata['annotations']:
    if annotation["image_id"] not in IMG_IDS_int:
        continue

    imgid = annotation['image_id']
    caption = annotation['caption']

    imgid_to_captions.setdefault(imgid, [])
    imgid_to_captions[imgid].append(caption)
    numCaps += 1

assert len(IMG_IDS_int) == len(imgid_to_captions)
assert set(IMG_IDS_int) == set(imgid_to_captions.keys())

print("=> There are {} captions for {} images.".format(numCaps,len(IMG_FILENAMES)))

print('Creating captions files...')
c = 0
for imgid_s, filename in zip(IMG_IDS, IMG_FILENAMES):

    imgid = int(imgid_s)

    captions = imgid_to_captions[imgid]

    dest_filename = 'COCO5k_test_' + imgid_s + '_en.txt'

    # Print Abnormal captions
    if len(captions) != 5:
        print("### Abnormal captions (len = {}) at file: {}".format(len(captions), dest_filename))
        # truncate to 5 captions
        captions = captions[:5]

    # Check image file exist
    if not os.path.exists(IMG_DIR + filename):
        print("### Can't find: {}".format(IMG_DIR + filename))

    with open(capDST_DIR + dest_filename, 'w+', encoding='utf-8') as file:
        # format id
        #id_s = "{:08}".format(imgid)

        if len(captions) != 5:
                print(dest_filename)
                print(captions)
                exit()

        file.write(str(imgid))
        for cap in captions:
            # Normalize cap
            cap = cap.strip()
            if (cap[-1] == '.'):
                cap = cap[:-1]
            
            if len(cap) < 20:
                print(cap)
                print(dest_filename)
                exit()

            file.write('\n' + cap.strip())

    c += 1
    print("[{}/{}] Create caption file: {}".format(c, len(IMG_FILENAMES), filename))