
Input = './word_counts/word_counts_googlevntk.txt'

print("Input file: {}".format(Input))
WordClasses = 0
TotalWords = 0

with open(Input, 'r', encoding='utf8') as f:
    for line in f:
        #print(line)

        words = int(line.split()[-1])

        WordClasses += 1
        TotalWords += words


print("#WordClasses = {}".format(WordClasses))
print("#TotalWords = {}".format(TotalWords))
