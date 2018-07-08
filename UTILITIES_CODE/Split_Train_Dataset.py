import shutil
import glob
import os

IMG_DIR = './Images_train'
ENCAP_DIR = './Captions_train_en'
GCAP_DIR = './Captions_train_googlevn'
MASTER_DIT = './DATASET_SPLIT'

imgfiles = glob.glob(IMG_DIR + '/*')
encapfiles = glob.glob(ENCAP_DIR + '/*')
gcapfiles = glob.glob(GCAP_DIR + '/*')


for i in range(40):
    print("Piece {}...".format(i+1))
    start = i * 100
    end = (i+1) * 100

    sel_imgfiles = imgfiles[start:end]
    
    foldername = "COCO5k_Piece_" + str(i + 1)
    folderpath = MASTER_DIT + '/' + foldername
    if not os.path.exists(folderpath):
        os.mkdir(folderpath)

    for file in sel_imgfiles:
        filename = os.path.splitext(os.path.basename(file))[0]
        encap_filename = filename + '_en.txt'
        gcap_filename = filename + '_googlevn.txt'
        # print(file)
        # print(folderpath + '/' + os.path.basename(file))
        shutil.copy(file, folderpath + '/' + os.path.basename(file))
        shutil.copy(ENCAP_DIR + '/' + encap_filename, folderpath + '/' + encap_filename)
        shutil.copy(GCAP_DIR + '/' + gcap_filename, folderpath + '/' + gcap_filename)



