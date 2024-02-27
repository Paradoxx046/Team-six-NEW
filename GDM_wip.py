import random
import sys
global health
health = 100
global energy
energy = 100
global dmg_sword
dmg_sword = random.randint(1,20)
global dmg_lasso
dmg_lasso = random.randint(1,5)
global act
act = 3

def action():
    global act
    global dmg_sword
    global dmg_lasso
    global health
    print("attack!")
    print("blade (1) or rope (2)?")    
    act = int(input())
    if act == int(1):
        print("You use the sword!")
        use_sword()
        
    elif act == int(2):
        print("You try the lasso!")
        use_lasso()
        
        
        
def player(): 
    global energy 
    
def beast(): 
    global health
    trust = 100 

def sword(): 
    global dmg_sword
    
def lasso(): 
    global dmg_lasso

def use_sword():
    global act
    while act == int(1):
            global health
            global energy
            global dmg_sword
            print('-', dmg_sword, "resistance")
            health -= dmg_sword
            energy -= 5
            print(health, 'creatures resolve')
            print(energy, "your remaining strength")
            act = (3)
            dmg_sword = random.randint(1,20)
            if health <= 0:
                    print("The creature is exhausted! Now's your chance.")
                    capture()
            else:
                    action()
            if energy <= 0:
                print("your energy is depleted and you pass out!")
                restart()
            else:
                action()
            action()

def use_lasso():
    global act
    while act == int(2):
            global health
            global energy
            global dmg_lasso
            print('-', dmg_lasso, "resistence")
            health -= dmg_lasso
            energy -= 5
                    
            print(health, 'creatures resolve')
            print(energy, "your remaining strength")
            act = (3)
            dmg_lasso = random.randint(1,5)
            if health <= 0:
                    print("The creature is exhausted! Now's your chance.")
                    capture()
            else:
                    action()
            if energy <= 0:
                print("your energy is depleted and you pass out!")
                restart()
            else:
                action()
            
def restart():
        global health
        global energy
        print("Let's try that again")
        health = 100
        energy = 100
        action()

def oppritunity():
        keep = input("Will you tame this beast? (y/n)  ")
        if keep == ('y'):
                capture()
        elif keep == ('n'):
                release()

def capture():
       print("Congradulations, the creature is now yours!")
       keep = input("Want to try again, yes or no?  ")
       if keep ==('yes') or keep ==('Yes'):
               print("awesome")
               restart()
       else:
                print("Very well, at another time then. Farewell")
                sys.exit(0)
                
def release():
        print("Interesting choice...")
        win = input("Shall we track down another, yes or no?   ")
        if win ==('yes'):
               restart()
        else:
                print("Very well, at another time then. Farewell")
                sys.exit(0)
                
 
player()
sword()
lasso()
use_sword()
use_lasso()
beast()
action()
restart()
oppritunity()
capture()
release()
