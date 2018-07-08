import json
import io
import nltk

Input = './json/captions_COCO5k_train_googlevntk.json'

print("Input file: {}".format(Input))
CapLengths = 0
NumCaps = 0

with io.open(Input, 'r', encoding='utf-8') as f:
    jsondata = json.load(f)

    for annotation in jsondata['annotations']:
        #print(annotation)
        caption = annotation['caption']

        CapList = nltk.tokenize.word_tokenize(caption.lower())

        CapLengths += len(CapList)
        NumCaps += 1
        #print(CapList)


print("#NumCaps = {}".format(NumCaps))
print("#CapLengths = {}".format(CapLengths))
print("#AvgCapLengths = {}".format(float(CapLengths)/float(NumCaps)))

