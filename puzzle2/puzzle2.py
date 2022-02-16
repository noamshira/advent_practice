import math

res=0

with open('C:\\Users\\1\\Desktop\\noamis.txt','r') as file:
    for line in file:
       s= line.split("x")
       s = [int(x) for x in s]
       s.sort()
       res+=sum(s[:2])*2+math.prod(s)
       #print(s)
       #res= res+s[0]+s[0]+s[1]+s[1]
       #res +=s[0]*s[1]*s[2]


print(res)


#1586300








