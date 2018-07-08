import shutil
import json
import io
import random
import os

'''
Get 4000 images from COCO train json file + Create Images folder and Captions folder
'''

ORG_DIR = './train2014/'
DST_DIR = './COCOvn/Images_train/'

capDST_DIR = './COCOvn/Captions_train_en/'

jsonfile = './annotations/captions_train2014.json'


### PREPARING FOLDERS
# Delete old data
if os.path.exists(DST_DIR):
    shutil.rmtree(DST_DIR)
if os.path.exists(capDST_DIR):
    shutil.rmtree(capDST_DIR)

os.mkdir(DST_DIR)
os.mkdir(capDST_DIR)


# Select number of images will be selected
N = 4000

with io.open(jsonfile, 'r', encoding='utf-8') as f:
    jsondata = json.load(f)

# Delete unneccessery fields
jsondata['licenses'] = []

imgs = [(x['id'], x["file_name"]) for x in jsondata["images"]]

# Only get N images
imgs = random.sample(imgs, N)

# List images ID
imgs_IDs = [x[0] for x in imgs]

# List images filepath
imgs_filepaths = [x[1] for x in imgs]

print('=' * 40)
print('Copying files to destination...')
c = 0
for filename in imgs_filepaths:
    srcpath = ORG_DIR + filename
    
    # Format dest filename
    fname = os.path.splitext(filename)[0]
    ext = os.path.splitext(filename)[-1]
    imgid = fname.split('_')[-1]
    dest_filename = 'COCO5k_train_' + imgid + ext

    dstpath = DST_DIR + dest_filename
    shutil.copyfile(srcpath, dstpath)
    
    c += 1
    if (c % 100 == 0):
        print("[{}/{}] Copy file: {}".format(c, len(imgs_filepaths), filename))

print('=' * 40)
print('Getting imgid_to_captions dict...')
numCaps = 0
imgid_to_captions = {}
for annotation in jsondata['annotations']:
    if annotation["image_id"] not in imgs_IDs:
        continue

    imgid = annotation['image_id']
    caption = annotation['caption']

    imgid_to_captions.setdefault(imgid, [])
    imgid_to_captions[imgid].append(caption)
    numCaps += 1

assert len(imgs) == len(imgid_to_captions)
assert set(imgs_IDs) == set(imgid_to_captions.keys())

print("=> There are {} captions for {} images.".format(numCaps,len(imgs)))

print('Creating captions files...')
c = 0
for (imgid, filename) in imgs:
    captions = imgid_to_captions[imgid]

    fname = os.path.splitext(filename)[0]
    fid = fname.split('_')[-1]
    dest_filename = 'COCO5k_train_' + fid + '_en.txt'

    # Print Abnormal captions
    if len(captions) != 5:
        print("### Abnormal captions (len = {}) at file: {}".format(len(captions), dest_filename))
        # truncate to 5 captions
        captions = captions[:5]

    # Abnormal file image ID
    if imgid != int(fid):
        print("### Abnormal file ID at file: {}".format(len(captions), dest_filename))

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
    if (c % 100 == 0):
        print("[{}/{}] Create caption file: {}".format(c, len(imgs), filename))