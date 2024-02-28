using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_code : MonoBehaviour
{
# include <iostream>
# include <cstdlib>
# include <ctime>
    int health = 100;
    int energy = 100;
    int dmg_sword = rand() % 20 + 1;
    int dmg_lasso = rand() % 5 + 1;
    int act = 3;

    void action();
    void player();
    void beast();
    void sword();
    void lasso();
    void use_sword();
    void use_lasso();
    void restart();
    void opportunity();
    void capture();
    void release();

    void action()
    {
        int act;
        int dmg_sword;
        int dmg_lasso;
        int health;
        std::cout << "attack!" << std::endl;
        std::cout << "blade (1) or rope (2)?" << std::endl;
        std::cin >> act;
        if (act == 1)
        {
            std::cout << "You use the sword!" << std::endl;
            use_sword();
        }
        else if (act == 2)
        {
            std::cout << "You try the lasso!" << std::endl;
            use_lasso();
        }
    }
    void player()
    {
        int energy;
    }
    void beast()
    {
        int health;
        int trust = 100;
    }
    void sword()
    {
        int dmg_sword;
    }
    void lasso()
    {
        int dmg_lasso;
    }
    void use_sword()
    {
        int act;
        while (act == 1)
        {
            int health;
            int energy;
            int dmg_sword;
            std::cout << "-" << dmg_sword << " resistance" << std::endl;
            health -= dmg_sword;
            energy -= 5;
            std::cout << health << " creatures resolve" << std::endl;
            std::cout << energy << " your remaining strength" << std::endl;
            act = 3;
            dmg_sword = rand() % 20 + 1;
            if (health <= 0)
            {
                std::cout << "The creature is exhausted! Now's your chance." << std::endl;
                capture();
            }
            else
            {
                action();
            }
            if (energy <= 0)
            {
                std::cout << "your energy is depleted and you pass out!" << std::endl;
                restart();
            }
            else
            {
                action();
            }
            action();
        }
    }
    void use_lasso()
    {
        int act;
        while (act == 2)
        {
            int health;
            int energy;
            int dmg_lasso;
            std::cout << "-" << dmg_lasso << " resistence" << std::endl;
            health -= dmg_lasso;
            energy -= 5;
            std::cout << health << " creatures resolve" << std::endl;
            std::cout << energy << " your remaining strength" << std::endl;
            act = 3;
            dmg_lasso = rand() % 5 + 1;
            if (health <= 0)
            {
                std::cout << "The creature is exhausted! Now's your chance." << std::endl;
                capture();
            }
            else
            {
                action();
            }
            if (energy <= 0)
            {
                std::cout << "your energy is depleted and you pass out!" << std::endl;
                restart();
            }
            else
            {
                action();
            }
        }
    }
    void restart()
    {
        int health;
        int energy;
        std::cout << "Let's try that again" << std::endl;
        health = 100;
        energy = 100;
        action();
    }
    void opportunity()
    {
        char keep;
        std::cout << "Will you tame this beast? (y/n)  ";
        std::cin >> keep;
        if (keep == 'y')
        {
            capture();
        }
        else if (keep == 'n')
        {
            release();
        }
    }
    void capture()
    {
        std::cout << "Congradulations, the creature is now yours!" << std::endl;
        char keep;
        std::cout << "Want to try again, yes or no?  ";
        std::cin >> keep;
        if (keep == 'yes' || keep == 'Yes')
        {
            std::cout << "awesome" << std::endl;
            restart();
        }
        else
        {
            std::cout << "Very well, at another time then. Farewell" << std::endl;
            exit(0);
        }
    }
    void release()
    {
        std::cout << "Interesting choice..." << std::endl;
        char win;
        std::cout << "Shall we track down another, yes or no?   ";
        std::cin >> win;
        if (win == 'yes')
        {
            restart();
        }
        else
        {
            std::cout << "Very well, at another time then. Farewell" << std::endl;
            exit(0);
        }
    }
    int main()
    {
        player();
        sword();
        lasso();
        use_sword();
        use_lasso();
        beast();
        action();
        restart();
        opportunity();
        capture();
        release();

        return 0;
    }
}
