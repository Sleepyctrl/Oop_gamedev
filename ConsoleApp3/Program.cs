using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
       
        public abstract class Player
        {
            
            public int hp;
            public int attack;
            public int defence_point;
            public bool defence_skill;
            public int ability_modifier;
            
            public abstract int ability(int calculation);
            public abstract int attack_enemy(int enemy_hp);

            public abstract bool defence();
        }


        public class Heal : Player
        {
            
            public Heal()
            {
                hp =  100;
                attack = 20;
                defence_point = 3;
                defence_skill = false;
                ability_modifier = 5;
               
            }
            public override bool defence()
            {

                return defence_skill = true;
            }
            public override int attack_enemy(int enemy_hp)
            {
                enemy_hp -= attack;
                return enemy_hp;
            }
            public override int ability(int calculation)
            {
                Random rnd = new Random();
                calculation = rnd.Next(0, ability_modifier);

                return hp +=(calculation * 4); 
            }
        }

        
        public class warrior : Player
        {
          public warrior()
            {
                hp = 150;
                attack = 15;
                defence_point = 6;
                defence_skill = false;
                ability_modifier = 5;
                
            }

            public override bool defence()
            {
                return defence_skill = true;
            }
            public override int attack_enemy(int enemy_hp)
            {

                return enemy_hp -= attack;
            }

            public override int ability(int calculation)
            {
                Random rnd = new Random();
                calculation = rnd.Next(0, ability_modifier);
                return attack += (calculation * 2);
            }
        }


        public abstract class Enemy
        {
            
            public int enemy_hp;
            public int enemy_attack;

            public abstract int Enemyattack(int player_hp);
            public abstract int tentacle_attack(int player_hp);

        }


        public class Boss1 : Enemy
        {
           public Boss1()
            {
                enemy_hp = 150;
                enemy_attack = 24;
            }

            public override int Enemyattack(int player_hp)
            {
                
                return player_hp -= enemy_attack;
            }

            public override int tentacle_attack(int player_hp)
            {
                return player_hp -= 40;
            }

        }


        static void Main(string[] args)
        {
            

            //  Player player1;
            // Enemy boss_1;

            Boss1 boss = new Boss1();
            Player player1 = new Heal();

            int i = 0;

            Console.WriteLine("Привет, сейчас тебе предстоит битва с боссом, предлагаю подготовится.");
            Console.ReadKey();
            Console.WriteLine("У тебя на выбор есть 2 класса: \r\n" +
                "1. Целитель \r\n" +
                "2. Воин \r\n" +
                "Введите порядковый номер класса, которым вы хотите быть, и помните, что выбор останется за вами до перезапуска игры.");
            do
            {
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Поздравляю, с окончанием выбора класса!");
                }
                catch
                {
                    Console.WriteLine("Пожалуйста, напиши порядковый номер класса, которым вы хотите играть !");
                }
            } while (i == 0);
            switch (i)
            {
                case 1:
                    player1 = new Heal();

                    boss.enemy_hp = player1.attack_enemy(boss.enemy_hp);
                    Console.WriteLine("Теперь ты целитель ! \r\n" +
                        "Посмотрим, как долго ты сможешь им оставаться :) ");
                    Console.WriteLine("Здоровье :" + player1.hp + " \r\nУрон :" + player1.attack);

                    break;
                case 2:
                    player1 = new warrior();
                    
                    Console.WriteLine("Ты стал воином! \r\n" +
                        "Интересно, бросишь ли ты свой меч, спасая свою шкуру ?  ");
                    Console.WriteLine("Здоровье :" + player1.hp + " \r\nУрон :" + player1.attack);
                    break;
            }
            Console.ReadKey();

            Console.WriteLine("" +
                    "__________________________________________________\r\n" +
                   "__________________111¶¶¶¶¶¶¶1_____________________\r\n" +
                   " ______________¶¶¶¶¶¶¶1¶1¶¶¶¶¶¶¶¶¶_________________\r\n" +
                   " ___________1¶¶¶¶1__¶¶___¶1____11¶¶¶¶______________\r\n" +
                    "__________¶¶¶_____1¶¶___1¶¶1___1¶¶¶¶¶1____________\r\n" +
                   " ________¶¶1_1¶¶¶¶¶¶¶_____1¶¶¶¶¶¶¶__1¶¶¶___________\r\n" +
                   " _______¶¶¶¶__1¶¶¶1________________¶¶1_¶¶1_________\r\n" +
                   " ______¶¶__¶_______________________¶1___1¶1________\r\n" +
                   " _____¶¶__¶¶______¶¶¶¶___¶¶¶¶______¶¶¶111¶¶________\r\n" +
                   " ____1¶¶¶¶¶______¶¶1¶¶__¶¶¶1¶1______1¶¶¶¶1¶¶_______\r\n" +
                   " ____¶111________¶11¶¶__1¶¶¶¶1____________1¶_______\r\n" +
                   " ____¶___________1¶¶¶1___1¶¶1_____________1¶_______\r\n" +
                   " ____¶1___________________________________1¶_______\r\n" +
                   " ____¶¶________111¶¶11¶¶¶¶1¶¶11___________¶¶_______\r\n" +
                   " _____¶¶¶____¶¶¶¶__¶¶1____¶¶_1¶¶¶¶________¶¶________\r\n" +
                   " ______¶¶¶¶_¶¶¶_________________¶¶¶_____1¶¶_________\r\n" +
                   " ________¶¶¶1_____________________¶¶___¶¶¶__________\r\n" +
                   " __________¶¶¶_______________________¶¶1___________\r\n" +
                   " ___________¶¶___________________¶___¶¶____¶¶¶_____\r\n" +
                   " ___________1¶____¶¶___¶¶___¶¶___¶¶__¶¶1__¶¶¶¶¶____\r\n" +
                    "___________¶¶___1¶¶___¶¶___¶¶___¶¶1_1¶¶¶¶¶¶1_¶¶___\r\n" +
                  "  __¶¶¶1__1¶¶¶¶___1¶____¶¶____¶1__1¶¶1___¶¶_____¶1__\r\n" +
                  "  _1¶11¶¶¶¶¶¶_____¶¶____¶1___¶¶¶____¶¶__________¶¶__\r\n" +
                  "  _¶¶__11________¶¶¶___1¶_____1¶____1¶¶________1¶1__\r\n" +
                   " _1¶___________¶¶¶____¶¶_____¶¶_____¶¶¶______¶¶¶___\r\n" +
                   " __¶¶1______1¶¶¶______¶¶_____1¶1_____1¶¶¶¶¶¶¶¶¶____\r\n" +
                   " ___11¶¶111¶¶¶¶¶_____1¶______¶¶1_____¶¶111111______\r\n" +
                   " ____¶¶¶¶¶¶¶¶¶_______¶¶______1¶¶______11¶1____11___\r\n" +
                   " ___¶¶__¶¶111_______¶¶1______¶¶¶________¶¶¶¶¶¶¶¶¶__\r\n" +
                   " ___¶¶_____________¶¶¶_______¶¶¶¶___________¶1_¶¶__\r\n" +
                  "  ____¶¶___________¶¶1¶_______¶¶_¶¶____________¶¶1__\r\n" +
                   " _____¶¶¶______1¶¶¶11¶_______¶¶_1¶¶11____111¶¶¶1___\r\n" +
                  "  ______¶¶¶¶¶¶¶¶¶¶¶___¶¶_______1¶1111¶¶¶¶¶¶¶¶¶1_____\r\n" +
                   " _________11¶11_______¶¶¶1_____111¶1_______________\r\n" +
                   " _______________________¶¶¶¶111111¶¶_______________\r\n" +
                   "Пред вами появляется чудовище огромных  размеров, вы понимаете,  лишь две вещи: \r\n" +
                   "1. От него явно пахнет тухлой рыбой. \r\n" +
                   "2. Оно явно хочет вас убить! \r\n" +
                   " Приготовтесь к бою.. Убейте его, и постарайтесь не умереть :)");
            int d = 0, k = 1, c = 0;
            do
            {
                d = 0;
                try
                {
                    Console.WriteLine("Ваше хп: " +player1.hp+
                        "\r\nВаш урон: " + player1.attack+
                        "\r\n\r\nЗдоровье чудища: " + boss.enemy_hp+
                        "\r\n\r\nВыберете, что вы хотите сделать! \r\n" +
                        "1.Напасть на противника.\r\n" +
                        "2.Защищаться (на следующий ход вы получить в двое меньше урона)\r\n" +
                        "3.Использовать способность\r\n " +
                        "а) Если вы лекарь, то добавьте себе кол-во хп равное от 0-20!\r\n" +
                        "б) Если вы воин, увельчите свою силу атаки на кол-во равное от 0-6 ");

                    d = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вы потратили свои силы в пустую, в следующий раз постарайтесь не ошибиться !");
                }
                
                switch (d)
                {
                    case 1:
                        Console.WriteLine("Вы атаковали, нанеся " + (boss.enemy_hp - player1.attack_enemy(boss.enemy_hp)) + "урона");
                        boss.enemy_hp=player1.attack_enemy(boss.enemy_hp);
                        break;
                        case 2:
                        player1.defence();
                        Console.WriteLine("Встав в защитную стойку, вы готовитесь к удару врага!");
                            break;
                            case 3:
                        player1.ability(0);
                        Console.WriteLine("Выпив батькиных трав, вы готовы продолжить бой!");
                        break;
                    default:
                        break;
                }
                
                Console.ReadKey();

                if (k == 4)
                {


                    if (player1.defence_skill == true)
                    {
                        Console.WriteLine("О БОЖЕ МОЙ! Этот осьминог-переросток размахивается своим щупальцем и наносит критический урон " + ((player1.hp - boss.tentacle_attack(player1.hp)) / 2) + " урона");
                        player1.hp -= ((player1.hp - boss.tentacle_attack(player1.hp) / 2));
                        player1.defence_skill = false;
                    }
                    else
                    {
                        Console.WriteLine("О БОЖЕ МОЙ! Этот осьминог-переросток размахивается своим щупальцем и наносит критический урон " + (player1.hp - boss.tentacle_attack(player1.hp)) + " урона");
                        player1.hp = boss.tentacle_attack(player1.hp);
                    }

                    k = 1;
                }
                else
                {
                    
                    Console.WriteLine("Огромное чудище выпускает в вас струю воды, нанося " + (player1.hp - boss.Enemyattack(player1.hp)) + " урона");
                    player1.hp = boss.Enemyattack(player1.hp);
                }
                k++;
                Console.ReadKey();
            } while (player1.hp > 0 && boss.enemy_hp > 0);




        }


    }
}
