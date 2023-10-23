using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace ikeaGameV2
{
    //Alistair Krieck
    //2023 - 10 - 23
    //A treck through Ikea
    public partial class Form1 : Form
    {
        int page = 1;
        int meatballCount = 0;
        SoundPlayer openingTrack = new SoundPlayer(Properties.Resources.Amazing_Plan);
        SoundPlayer bedDisplayTrack = new SoundPlayer(Properties.Resources.Scheming_Weasel__faster_Version_);
        SoundPlayer cafeTrack = new SoundPlayer(Properties.Resources.Monkeys_Spinning_Monkeys);
        SoundPlayer winTrack = new SoundPlayer(Properties.Resources.win_music);
        SoundPlayer warehouseTrack = new SoundPlayer(Properties.Resources.Fluffing_a_Duck);
        SoundPlayer deathTrack = new SoundPlayer(Properties.Resources.burning_memory);
        SoundPlayer civilaizationTrack = new SoundPlayer(Properties.Resources.dreamy_piano);
        SoundPlayer shock = new SoundPlayer(Properties.Resources.shocked_sound_effect);
        SoundPlayer checkoutTrack = new SoundPlayer(Properties.Resources.Pharrell_Williams_Happy_Official_Video);

        public Form1()
        {
            InitializeComponent();

            outputLabel.Text = "You needed a new table. You ventured out to a local Ikea to buy some high-quality Swedish furniture. After a few hours, you find yourself lost.";
            questionOutput.Text = "Where do you go?";
            input1.Text = "The Cafeteria";
            input2.Text = "The Bedroom Displays";
            Refresh();
            openingTrack.Play();
            pictureBox.Image = Properties.Resources.IKEA_store_entrance;
        }

        private void input1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 2;
            }
            else if (page == 7)
            {
                Random randGen = new Random();
                int randValue = randGen.Next(0, 101);

                if (randValue >= 50)
                {
                    page = 8;
                }
                else
                {
                    page = 10;
                }
            }
            else if (page == 8)
            {
                page = 99;
            }

            else if (page == 9)
            {
                page = 11;
            }

            else if (page == 10)
            {
                page = 13;
            }

            else if (page == 11)
            {
                page = 101;
            }

            else if (page == 12)
            {
                page = 99;
            }

            else if (page == 13)
            {
                page = 15;
            }

            else if (page == 14)
            {
                page = 1;
            }

            else if (page == 15)
            {
                page = 101;
            }

            else if (page == 16)
            {
                page = 1;
            }
            //--
            else if (page == 99)
            {
                page = 1;
            }

            else if (page == 101)
            {
                page = 1;
            }


            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    meatballCount = 0;
                    outputLabel.Text = "You needed a new table. You ventured out to a local Ikea to buy some high-quality Swedish furniture. After a few hours, you find yourself lost.";
                    questionOutput.Text = "Where do you go?";
                    input1.Text = "The Cafeteria";
                    input2.Text = "The Bedroom Displays";
                    pictureBox.Image = Properties.Resources.IKEA_store_entrance;
                    openingTrack.Play();

                    break;
                case 2:
                    meatballCount++;
                    outputLabel.Text = "You decide to head towards the cafeteria.You think you remember passing through here before.";
                    questionOutput.Text = "Do you grab some food? Remember, you may be here for a long time.";
                    input1.Text = "Yes";
                    input2.Text = "No";
                    pictureBox.Image = Properties.Resources.ikeaCafe;
                    cafeTrack.Play();

                    break;
                case 3:
                    outputLabel.Text = "You head towards the bedroom displays. You think you remember passing through here before.";
                    questionOutput.Text = "Do you try and remember the path you took and backtrack?";
                    input1.Text = "Yes";
                    input2.Text = "No";
                    pictureBox.Image = Properties.Resources.ikeaBedroom;
                    bedDisplayTrack.Play();
                    break;
                case 4:
                    meatballCount++;
                    outputLabel.Text = "You grab a meal, then stuff your pockets with some delicious swedish meatballs.";
                    questionOutput.Text = "Do you grab more food, or head to the appliances?";
                    input1.Text = "Grab more food.";
                    input2.Text = "Head to the appliance displays.";
                    break;
                case 5:
                    outputLabel.Text = "You decide you don't need to eat. Surely you'll escape soon enough, right?";
                    questionOutput.Text = "...";
                    input1.Text = "...";
                    input2.Text = "...";

                    input1.Enabled = false;
                    input2.Enabled = false;
                    Refresh();
                    Thread.Sleep(3000);
                    input1.Enabled = true;
                    input2.Enabled = true;

                    outputLabel.Text = "You lose you mind from hunger, and stop wanting to esacpe.";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";

                    break;
                case 6:
                    outputLabel.Text = "You rack your brain for any information you can get. You think of two places you passed through.";
                    questionOutput.Text = "Do you go to the cafeteria or warehouse?";
                    input1.Text = "The Cafeteria";
                    input2.Text = "The Warehouse";
                    break;
                case 7:
                    outputLabel.Text = "You stuff your pockets with more meatballs.";
                    questionOutput.Text = "...";
                    input1.Text = "...";
                    input2.Text = "...";

                    input1.Enabled = false;
                    input2.Enabled = false;
                    Refresh();
                    Thread.Sleep(3000);
                    input1.Enabled = true;
                    input2.Enabled = true;

                    outputLabel.Text = "Starving Ikea denizens see you hoarding the food and attack.";
                    questionOutput.Text = "RUN!";
                    break;
                case 8:
                    outputLabel.Text = "They follow you for what must have been days, but you lose them. In your haste, you lose your way.";
                    questionOutput.Text = "...";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";
                    break;
                case 9:
                    outputLabel.Text = "You find a civilization growing.";
                    questionOutput.Text = "Do you join them or ask for directions?";
                    input1.Text = "Join them";
                    input2.Text = "Ask for directions";
                    pictureBox.Image = Properties.Resources.ikea_civ;
                    civilaizationTrack.Play();

                    break;
                case 10:
                    outputLabel.Text = "You find yourself in the warehouse";
                    questionOutput.Text = "Do you try and find the items on your list, or continue searching for the exit?";
                    input1.Text = "Find the list";
                    input2.Text = "Exit now";
                    pictureBox.Image = Properties.Resources.ikeaWarehouse;
                    warehouseTrack.Play();
                    break;
                case 11:
                    outputLabel.Text = "They open their gates and invite you in. You live out the rest of your days in luxury, gourging yourself on meatballs for breakfast, lunch, and dinner";
                    questionOutput.Text = "...";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";
                    break;
                case 12:
                    outputLabel.Text = "They glare at you, and say in a monotone voice, 'If we knew, we wouldn't be here.' ";
                    questionOutput.Text = "...";
                    input1.Text = "...";
                    input2.Text = "...";

                    input1.Enabled = false;
                    input2.Enabled = false;
                    Refresh();
                    Thread.Sleep(3000);
                    input1.Enabled = true;
                    input2.Enabled = true;

                    outputLabel.Text = "They chase you through the endless corridors until you are discovered by the employees.";
                    questionOutput.Text = "...";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";
                    break;
                case 13:
                    outputLabel.Text = "You note the codes for the items you want to purchase; however, you see an exit to your left. ";
                    questionOutput.Text = "Do you exit now, or find the checkout?";
                    input1.Text = "Find the checkout";
                    input2.Text = "Exit now";
                    break;
                case 14:
                    outputLabel.Text = "You eventually find the exit, and return home. However, you haven't gotten your table yet, so you go back.";
                    questionOutput.Text = "...";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";
                    pictureBox.Image = Properties.Resources.house;
                    shock.Play();

                    break;
                case 15:
                    outputLabel.Text = "You find the checkout quickly, and purchase you items.";
                    questionOutput.Text = "...";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";
                    pictureBox.Image = Properties.Resources.ikea_checkout;
                    checkoutTrack.Play();

                    break;
                case 16:
                    outputLabel.Text = "You eventually find the exit, and return home. However, you haven't gotten your table yet, so you go back.";
                    questionOutput.Text = "...";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";
                    pictureBox.Image = Properties.Resources.house;
                    shock.Play();
                    break;

                case 99:
                    outputLabel.Text = $"You are lost. You wander the endless halls until you are eventually discovered. You are forced to become an employee for the rest of time. \n\n You had {meatballCount} meatballs!";
                    questionOutput.Text = "Continue?";
                    input1.Text = "Yes";
                    input2.Text = "No";
                    deathTrack.Play();
                        pictureBox.Image = Properties.Resources.loseScreen1;
                        Refresh();
                        Thread.Sleep(1000);
                        pictureBox.Image = Properties.Resources.loseScreen2;
                        Refresh();
                        Thread.Sleep(1000);
                        pictureBox.Image = Properties.Resources.loseScreen3;
                        Refresh();
                        Thread.Sleep(1000);
                        pictureBox.Image = Properties.Resources.loseScreen4;
                        Refresh();
                        Thread.Sleep(1000);
                    break;

                case 100:
                    outputLabel.Text = "Thank you for playing!";
                    questionOutput.Text = "...";
                    input1.Text = "...";
                    input2.Text = "...";
                    Refresh();
                    Thread.Sleep(5000);
                    Close();
                    break;

                case 101:
                    outputLabel.Text = $"You win! \n\n You had {meatballCount} meatballs!";
                    questionOutput.Text = "Continue?";
                    input1.Text = "Yes";
                    input2.Text = "No";
                    winTrack.Play();
                    pictureBox.Image = Properties.Resources.winScreen1;
                    break;
            }
        }

        private void input2_Click(object sender, EventArgs e)
        {
            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 9;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 10;
            }
            else if (page == 7)
            {
                Random randGen = new Random();
                int randValue = randGen.Next(0, 101);

                if (randValue >= 50)
                {
                    page = 8;
                }
                else
                {
                    page = 10;
                }
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 12;
            }
            else if (page == 10)
            {
                page = 14;
            }
            else if (page == 11)
            {
                page = 101;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 16;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 101;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 99)
            {
                page = 100;
            }
            else if (page == 101)
            {
                page = 100;
            }


            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    meatballCount = 0;
                    outputLabel.Text = "You needed a new table. You ventured out to a local Ikea to buy some high-quality Swedish furniture. After a few hours, you find yourself lost.";
                    questionOutput.Text = "Where do you go?";
                    input1.Text = "The Cafeteria";
                    input2.Text = "The Bedroom Displays";
                    pictureBox.Image = Properties.Resources.IKEA_store_entrance;
                    openingTrack.Play();

                    break;
                case 2:
                    outputLabel.Text = "You decide to head towards the cafeteria.You think you remember passing through here before.";
                    questionOutput.Text = "Do you grab some food? Remember, you may be here for a long time.";
                    input1.Text = "Yes";
                    input2.Text = "No";
                    pictureBox.Image = Properties.Resources.ikeaCafe;
                    cafeTrack.Play();

                    break;
                case 3:
                    outputLabel.Text = "You head towards the bedroom displays. You think you remember passing through here before.";
                    questionOutput.Text = "Do you try and remember the path you took and backtrack?";
                    input1.Text = "Yes";
                    input2.Text = "No";
                    pictureBox.Image = Properties.Resources.ikeaBedroom;
                    bedDisplayTrack.Play();
                    break;
                case 4:
                    outputLabel.Text = "You grab a meal, then stuff your pockets with some delicious swedish meatballs.";
                    questionOutput.Text = "Do you grab more food, or head to the appliances?";
                    input1.Text = "Grab more food.";
                    input2.Text = "Head to the appliance displays.";
                    break;
                case 5:
                    outputLabel.Text = "You decide you don't need to eat. Surely you'll escape soon enough, right?";
                    questionOutput.Text = "...";
                    input1.Text = "...";
                    input2.Text = "...";

                    input1.Enabled = false;
                    input2.Enabled = false;
                    Refresh();
                    Thread.Sleep(3000);
                    input1.Enabled = true;
                    input2.Enabled = true;

                    outputLabel.Text = "You lose you mind from hunger, and stop wanting to esacpe.";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";

                    break;
                case 6:
                    outputLabel.Text = "You rack your brain for any information you can get. You think of two places you passed through.";
                    questionOutput.Text = "Do you go to the cafeteria or warehouse?";
                    input1.Text = "The Cafeteria";
                    input2.Text = "The Warehouse";
                    break;
                case 7:
                    outputLabel.Text = "You stuff your pockets with more meatballs.";
                    questionOutput.Text = "...";
                    input1.Text = "...";
                    input2.Text = "...";

                    input1.Enabled = false;
                    input2.Enabled = false;
                    Refresh();
                    Thread.Sleep(3000);
                    input1.Enabled = true;
                    input2.Enabled = true;

                    outputLabel.Text = "Starving Ikea denizens see you hoarding the food and attack.";
                    questionOutput.Text = "RUN!";
                    break;
                case 8:
                    outputLabel.Text = "They follow you for what must have been days, but you lose them. In your haste, you lose your way.";
                    questionOutput.Text = "...";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";
                    break;
                case 9:
                    outputLabel.Text = "You find a civilization growing.";
                    questionOutput.Text = "Do you join them or ask for directions?";
                    input1.Text = "Join them";
                    input2.Text = "Ask for directions";
                    pictureBox.Image = Properties.Resources.ikea_civ;
                    civilaizationTrack.Play();
                    break;
                case 10:
                    outputLabel.Text = "You find yourself in the warehouse";
                    questionOutput.Text = "Do you try and find the items on your list, or continue searching for the exit?";
                    input1.Text = "Find the list";
                    input2.Text = "Exit now";
                    pictureBox.Image = Properties.Resources.ikeaWarehouse;
                    warehouseTrack.Play();
                    break;
                case 11:
                    outputLabel.Text = "They open their gates and invite you in. You live out the rest of your days in luxury, gourging yourself on meatballs for breakfast, lunch, and dinner";
                    questionOutput.Text = "...";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";
                    break;
                case 12:
                    outputLabel.Text = "They glare at you, and say in a monotone voice, 'If we knew, we wouldn't be here.' ";
                    questionOutput.Text = "...";
                    input1.Text = "...";
                    input2.Text = "...";

                    input1.Enabled = false;
                    input2.Enabled = false;
                    Refresh();
                    Thread.Sleep(3000);
                    input1.Enabled = true;
                    input2.Enabled = true;

                    outputLabel.Text = "They chase you through the endless corridors until you are discovered by the employees.";
                    questionOutput.Text = "...";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";
                    break;
                case 13:
                    outputLabel.Text = "You note the codes for the items you want to purchase; however, you see an exit to your left. ";
                    questionOutput.Text = "Do you exit now, or find the checkout?";
                    input1.Text = "Find the checkout";
                    input2.Text = "Exit now";
                    break;
                case 14:
                    outputLabel.Text = "You eventually find the exit, and return home. However, you haven't gotten your table yet, so you go back.";
                    questionOutput.Text = "...";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";
                    pictureBox.Image = Properties.Resources.house;
                    shock.Play();
                    break;
                case 15:
                    outputLabel.Text = "You find the checkout quickly, and purchase you items.";
                    questionOutput.Text = "...";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";
                    pictureBox.Image = Properties.Resources.ikea_checkout;
                    checkoutTrack.Play();
                    break;
                case 16:
                    outputLabel.Text = "You eventually find the exit, and return home. However, you haven't gotten your table yet, so you go back.";
                    questionOutput.Text = "...";
                    input1.Text = "Continue...";
                    input2.Text = "Continue...";
                    pictureBox.Image = Properties.Resources.house;
                    shock.Play();
                    break;

                case 99:
                    outputLabel.Text = $"You are lost. You wander the endless halls until you are eventually discovered. You are forced to become an employee for the rest of time. \n\n You had {meatballCount} meatballs!";
                    questionOutput.Text = "Continue?";
                    input1.Text = "Yes";
                    input2.Text = "No";
                    deathTrack.Play();                 
                        pictureBox.Image = Properties.Resources.loseScreen1;
                        Refresh();
                        Thread.Sleep(1000);
                        pictureBox.Image = Properties.Resources.loseScreen2;
                        Refresh();
                        Thread.Sleep(1000);
                        pictureBox.Image = Properties.Resources.loseScreen3;
                        Refresh();
                        Thread.Sleep(1000);
                        pictureBox.Image = Properties.Resources.loseScreen4;
                        Refresh();
                        Thread.Sleep(1000);
                    
                    break;

                case 100:
                    outputLabel.Text = "Thank you for playing!";
                    questionOutput.Text = "...";
                    input1.Text = "...";
                    input2.Text = "...";
                    Refresh();
                    Thread.Sleep(5000);
                    Close();
                    break;

                case 101:
                    outputLabel.Text = $"You win! \n\n You had {meatballCount} meatballs!";
                    questionOutput.Text = "Continue?";
                    input1.Text = "Yes";
                    input2.Text = "No";
                    pictureBox.Image = Properties.Resources.winScreen1;
                    winTrack.Play();
                    break;
            }
        }

    }
}

