import json
from googletrans import Translator
import codecs
import time

translator = Translator()

src_json = "captions_train2014.json"
dst_json = "captions_train2014_vn.json"

with open(src_json, "r") as jsonFile:
    data = json.load(jsonFile)

# Only get 1000 images to test
CutNumber = 1000
data["images"] = data["images"][:CutNumber]
image_ids = [x["id"] for x in data["images"]]

newdata_annotations = []

data["licenses"] = []
#data["annotations"] = data["annotations"][:10]

# Using for multi Thread (Need work)
def ProcessThread(startid = 0, endid = 1):
    c = 0
    for annotation in data["annotations"][startid:endid]:
        if annotation["image_id"] not in image_ids:
            continue
        
        start = time.time()
    
        cap_id = annotation["id"]
        image_id = annotation["image_id"]
        caption = annotation["caption"]
        
        new_annotation = annotation
        
        # Google API translate
        #caption_vn = translator.translate(caption, dest='vi').text
    
        ## Set caption to vietnamese
        new_annotation["caption"] = caption
        
        newdata_annotations.append(new_annotation)
        
        c += 1
        #print("[{}/{}] ID {}".format(c, len(data["annotations"]), cap_id))
        if (c % 10 == 0):
            end = time.time()
            print("[{}/{}] ID {} in {:.4f} sec => {}".format(c, len(data["annotations"]), cap_id, end - start, caption.encode('utf-8')))


ProcessThread(0, len(data["annotations"]))

data["annotations"] = newdata_annotations


with codecs.open(dst_json, 'w', encoding='utf-8') as jsonFile:
    json.dump(data, jsonFile, ensure_ascii=False)