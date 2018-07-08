import glob
import shutil
import random
import os
import time

'''
Randomly select captions
'''

InputDIR = './Captions_train_4000vntk'
OutputDIR = './Captions_train_1600vntk'
nFiles = 1600

if not os.path.exists(OutputDIR):
    os.mkdir(OutputDIR)
else:
    shutil.rmtree(OutputDIR)
    os.mkdir(OutputDIR)

AllFiles = glob.glob(InputDIR + '/*')
random.shuffle(AllFiles)
RandomFiles = AllFiles[:nFiles]

print("AllFiles: {}".format(len(set(AllFiles))))
print("RandomFiles: {}".format(len(set(RandomFiles))))
c = 0
LL = []
for file in RandomFiles:
    fname = os.path.basename(file)

    fdst_path = OutputDIR + '/' + fname
    
    shutil.copy(file, fdst_path)

    if not os.path.exists(fdst_path):
        print("Not found: {}".format(fdst_path))
        time.sleep(0.1)
    else:
        LL.append(fdst_path)

    c += 1
    if (c % 100 == 0):
        print('[{}/{}] file: {}'.format(c, len(RandomFiles), file))


print("{}".format(len(LL)))

print("OutputDIR: {}".format(len(glob.glob(OutputDIR+'/*'))))
