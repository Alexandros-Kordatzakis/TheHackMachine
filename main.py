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


# IP List (FAKE) - Port List 

IP = '6.55.126.1'
#IP2 = '104.89.49.11'
#IP3 = '104.107.158.41'
#IP4 = '23.214.28.211'

Port = "995"
#Port2 = "80"
#Port3 = "128"
#Port4 = "443"


##TODO: Implement  "random.choice()()"  for the multiple IP's and Port's.

# IPList = ['6.55.126.1', '104.89.49.11', '23.37.56.152', '104.107.158.41', '23.214.28.211', '104.24.127.181']
# PortList = ['80', '443', '128', '21', '995', '143']




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


AlgList = [mainAlgOp2, mainAlgOp1]

start = datetime.now()
random.choice(AlgList)()
end = datetime.now() - start
print('Time elapsed (hh:mm:ss.ms) {}'.format(end))


# Generate Report.
f = open("Report.txt","w+")
f.write("The site was HACKED succesfully!")
f.write("\nSite: ")
f.write(hck_site)

f.write("\n\nIP: ")
f.write(IP)
f.write("\nPort: ")
f.write(Port)

f.write("\n\nTime elapsed (hh:mm:ss.ms): ")
f.write(format(end))

f.write("\n\nReport Generated "+time.strftime("%Y-%m-%d_%H:%M:%S GMT", time.gmtime()))
f.write("\nReport Generated "+time.strftime("%Y-%m-%d_%H:%M:%S Local Time", time.localtime()))


print("\n")
print("\n")
print("DONE! Check the Report.txt file for further info.")