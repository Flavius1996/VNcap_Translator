import os
import glob
import random
import shutil

'''
COCO5k VN utility-code:
    Mixing between Human translate and google translate to create new dataset
'''

########## MAKE CHANGE BY EDIT HERE ##################
# DIR to 4000 Human translated captions folder
Human_DIR = './COCO5k/Captions_train_4000vntk'
# DIR to 4000 Google translated captions folder
Google_DIR = './COCO5k/Captions_train_googlevntk'
# Suffix for Human/Google caption file
Human_file_suffix = '_vntk'
Google_file_suffix = '_googlevntk'

# New mixing dir will saved here
new_MIX_DIR = './COCO5k/Captions_train_MixType1_googlecap4plus1_4000tk'
# New suffix for Mix caption file
new_MIX_suffix = '_googlecap4plus1_tk'

# image file prefix
fprefix = "COCO5k_train_"

if not os.path.exists(new_MIX_DIR):
    os.mkdir(new_MIX_DIR)

All_Humanfiles = glob.glob(Human_DIR + '/*.txt')
All_Googlefiles = glob.glob(Google_DIR + '/*.txt')
assert len(set(All_Humanfiles)) == len(set(All_Googlefiles))
######################################################

def checkFileExist(filepath):
    return os.path.exists(filepath)

def writeCapfile(filepath, imgid, captions):
    '''
    Write list of captions to file
    '''
    with open(filepath, 'w+', encoding='utf-8') as file:
        # format id
        #id_s = "{:08}".format(imgid)

        if len(captions) != 5:
            print(filepath)
            print(captions)
            exit()

        file.write(str(imgid))
        for cap in captions:
            # Normalize cap
            cap = cap.strip()
            if (cap[-1] == '.'):
                cap = cap[:-1]
            
            if len(cap) < 10:
                print(cap)
                print(filepath)
                exit()

            file.write('\n' + cap.strip())

def Mix_Type_1(all_humanfiles, all_googlefiles, nGooglecap = 4, nHumancap = 1):
    '''
    Mixing type 1:
        4000 google translated images:
            <nGooglecap> captions
            + <nHumancap> human translated captions for each image
            = 5 captions
    '''
    c = 0
    print(Mix_Type_1.__doc__)
    for googlefile in all_googlefiles:
        fname = os.path.splitext(os.path.basename(googlefile))[0]
        human_fname = '_'.join(fname.split('_')[:-1]) + Human_file_suffix
        human_fpath = Human_DIR + '/' + human_fname + '.txt'

        with open(googlefile, 'r', encoding='utf-8') as fi:
            google_lines = [x.strip() for x in fi.readlines()]
        google_imgid = int(google_lines[0])
        google_captions = google_lines[1:]


        if (checkFileExist(human_fpath)):
            # Get random 1 caption from 5 Human captions to add to Google captions
            with open(human_fpath, 'r', encoding='utf-8') as f:
                lines = [x.strip() for x in f.readlines()]
            imgid = int(lines[0])
            captions = lines[1:]

            assert google_imgid == imgid
            assert len(google_captions) == len(captions)
            assert len(google_captions) == 5

            # Recheck Image ID in context and filename
            fid = "{:012}".format(imgid)
            txtfilename = fprefix + fid + Human_file_suffix + '.txt'
            assert checkFileExist(Human_DIR + '/' + txtfilename)

            # Random choose a number
            random_indexes = random.sample([0,1,2,3,4], nHumancap)

            # Change google caption to Human caption
            for i in random_indexes:
                google_captions[i] = captions[i]
            

            newFilename = '_'.join(fname.split('_')[:-1]) + new_MIX_suffix + '.txt'
            newFilepath = new_MIX_DIR + '/' + newFilename

            writeCapfile(newFilepath, imgid, google_captions)

            c += 1
            if (c % 200 == 0):
                print('[{}/{}] Mix File: {} - Random indexes: {}'.format(c, len(all_googlefiles), newFilepath, random_indexes))

        else:
            # Print error
            print("Can't find Human translated caption file: {}".format(human_fpath))
            exit()

def Mix_Type_2(all_humanfiles, all_googlefiles):
    '''
    Mixing type 2:
        4000 images:
            800 human translated images
            + 3200 google translated images
    '''
    print(Mix_Type_2.__doc__)
    c = 0
    nHumanFiles = 800

    # Random sample 800 images from human translated data
    Human_randomfiles = random.sample(all_humanfiles, nHumanFiles)
    print("Step 1: Copy Human translated images: ")
    for file in Human_randomfiles:
        fname = os.path.basename(file)
        fdst_path = new_MIX_DIR + '/' + fname
        # Copy to dest
        shutil.copy(file, new_MIX_DIR)
        c += 1
        if (c % 10 == 0):
            print("\t[{}/{}] images: {}".format(c,len(set(Human_randomfiles)), fname))

    print("\nStep 2: Copy Google translated images: ")
    c = 0
    for file in all_googlefiles:
        fname_wext = os.path.splitext(os.path.basename(file))[0]
        human_fname = '_'.join(fname_wext.split('_')[:-1]) + Human_file_suffix + '.txt'
        fdst_path = os.path.join(new_MIX_DIR, human_fname)

        # Pass already file copy from Human
        if (checkFileExist(fdst_path)):
            continue

        shutil.copy(file, new_MIX_DIR)
        c += 1
        if (c % 10 == 0):
            print("\t[{}/{}] images: {}".format(c,len(set(all_googlefiles)) - len(set(Human_randomfiles)), fname_wext))

def main():
    global All_Humanfiles, All_Googlefiles

    Mix_Type_1(All_Humanfiles, All_Googlefiles, 4, 1)

if __name__ == '__main__':
    main()

