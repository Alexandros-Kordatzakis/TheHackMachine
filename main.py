#!/usr/bin/env/ python3

import sys
import time
import os
import pyfiglet 
import random
from datetime import datetime


# import nmap
# import argparse


# OS ?!

# if (os.name == "posix"):
#     print(os.system("uname -a"))
# else:
#   print("Unknown OS")



# Use ARGPARSE for custom commands ?!?!?

# parser = argparse.ArgumentParser(description="\nUsage: Hack any site!")
# parser.add_argument("-p", help="Run a IP scan.", action="")
# parser.add_argument("-w", help="Generate a Report after the completion of the process.")
# parser.add_argument("-h", help="Show This Message.")
# parsed_args = parser.parse_args()



# Use of NMAP for more Creativity ?!

# nm_scan = nmap.PortScanner()
# nm_scanner = nm_scan.scan(sys.argv[1],'80',arguments='-p') 



ascii_banner = pyfiglet.figlet_format("TheHackMachine!")
print(ascii_banner)

# Animation DEF:
def progressbar(it, prefix="", size=60, file=sys.stdout):
    count = len(it)
    def show(j):
        x = int(size*j/count)
        file.write("%s[%s%s] %i/%i\r" % (prefix, "#"*x, "."*(size-x), j, count))
        file.flush()        
    show(0)
    for i, item in enumerate(it):
        yield item
        show(i+1)
    file.write("\n")
    file.flush()

def progressbar2(it, prefix="", size=60, file=sys.stdout):
    count = len(it)
    def show(j):
        x = int(size*j/count)
        file.write("%s[%s%s] %i/%i\r" % (prefix, "&"*x, "."*(size-x), j, count))
        file.flush()        
    show(0)
    for i, item in enumerate(it):
        yield item
        show(i+1)
    file.write("\n")
    file.flush()


def mainFunc():
  os.system('clear')
  print("\nI'm starting to HACK", hck_site,"!")
  print("\n")

hck_site = input("Write the Site's Name you want to HACK!\n\n")
hck_site = hck_site.upper()
mainFunc()


##TODO: Implement  "random.choice()()"  for the multiple IP's and Port's.   UPDATE: This method looks good.
## 2(3) Options for this one.   1) JSON data.    2) Radnom Numbers Generator Algorithm with specific number length.     3) Random Generated Numbers into a JSON (xD)


# IP / PORT Part:


def random_ip_algorithm():
    return str(random.randint(1, 255))+'.'+str(random.randint(1, 255))+'.'+str(random.randint(1, 255))+'.'+str(random.randint(1, 255))

def random_port_algorithm():
    return str(random.choice([random.randint(8, 1023), random.randint(8, 65000)]))




# Animations

time.sleep(4)

def mainAlgOp1():  # Animation Alg Option 1

  for i in progressbar(range(25), "Computing: ", 40):
      time.sleep(0.4) 

  print("\n")

  for i in progressbar(range(10), "IP: ", 25):
      time.sleep(0.2) 

  for i in progressbar2(range(35), "MAC: ", 40):
      time.sleep(0.1)

  for i in progressbar(range(30), "NMap: ", 30):
      time.sleep(0.8)         

  print("\n")

  for i in progressbar(range(45), "Server: ", 45):
      time.sleep(0.5) 

  for i in progressbar(range(95), "Server ###### ###: ", 50):
      time.sleep(0.2)     

  print("\n")   

  for i in progressbar(range(100), "#####: ", 55):
      time.sleep(0.1) 

  for i in progressbar2(range(122), "#### ## #### ###: ", 20):
      time.sleep(0.3)          

  time.sleep(5)


def mainAlgOp2():   # Animation Alg Option 2

  for i in progressbar(range(22), "Computing: ", 40):
      time.sleep(0.4) 

  print("\n")

  for i in progressbar(range(14), "IP: ", 26):
      time.sleep(0.2) 

  for i in progressbar2(range(35), "MAC: ", 40):
      time.sleep(0.1)

  for i in progressbar(range(36), "NMap: ", 35):
      time.sleep(0.7)         

  print("\n")

  for i in progressbar(range(42), "Server: ", 42):
      time.sleep(0.5) 

  for i in progressbar(range(95), "Server ###### ###: ", 50):
      time.sleep(0.2)     

  print("\n")   

  for i in progressbar(range(105), "#####: ", 52):
      time.sleep(0.1) 

  for i in progressbar2(range(122), "#### ## #### ###: ", 20):
      time.sleep(0.3)          

  time.sleep(5)


alg_list = [mainAlgOp2, mainAlgOp1]

start = datetime.now()
random.choice(alg_list)()
end = datetime.now() - start
print('Time elapsed (hh:mm:ss.ms) {}'.format(end))


# Generate Report.
f = open("Report.txt","w+")
f.write("The site was HACKED succesfully!")
f.write("\nSite: ")
f.write(hck_site)

f.write("\n\nIP: "+random_ip_algorithm())
f.write("\nPort: "+random_port_algorithm())

f.write("\n\nTime elapsed (hh:mm:ss.ms): ")
f.write(format(end))

f.write("\n\nReport Generated "+time.strftime("%Y-%m-%d_%H:%M:%S GMT", time.gmtime()))
f.write("\nReport Generated "+time.strftime("%Y-%m-%d_%H:%M:%S Local Time", time.localtime()))

f.close()


print("\n")
print("\n")
print("DONE! Check the Report.txt file for further info.")