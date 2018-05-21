﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MileStoneClient.BusinessLayer;
using MileStoneClient.Logger;

namespace MileStoneClient.PresentationLayer
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private ChatRoom chatRoom;
        private MainWindow mainWindow;
        private ObservableObject obs;
        private String nickname;
        private String groupId;

        public RegisterWindow(MainWindow mainWindow, ChatRoom chatRoom, ObservableObject obs)
        {
            Log.Instance.info("Registration window opened"); //log

            InitializeComponent();
            this.obs = obs;
            this.chatRoom = chatRoom;
            this.mainWindow = mainWindow;
            this.DataContext = obs;
            obs.BtnRegIsEnabled = false;
            obs.LblRegErrorVisibility = "Hidden";
            obs.LblAddLoginVisibility = "Hidden";
            obs.BtnLoginVisibility = "Hidden";
        }

        public ChatRoom GetChatRoom()
        {
            return this.chatRoom;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Log.Instance.info("User returned from registration window to main window");// log

            this.Close();
            this.mainWindow.Show();
            obs.LblRegErrorVisibility = "Hidden";
            obs.LblRegErrorContent = "";
            obs.LblAddLoginContent = "";
            obs.LblAddLoginVisibility = "Hidden";
            obs.BtnLoginVisibility = "Hidden";
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            int number;
            // A validity check of the NickName
            if (this.nickname[0] == ' ')// if the user presses space 
            {
                string message = "Nickname cannot start with spaces!";
                string caption = "Invalid name";
                if ((MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Error) == MessageBoxResult.OK))
                {
                    obs.GroupIdText = "";
                    obs.NicknameText = "";
                }
                Log.Instance.warn("Invalid input - Invalid nickname");//log
            }
            // A validity check of the group id
            else if (int.TryParse(groupId, out number) == false || (groupId.Length > 2))
            {// if the group Id is not between 1-99
                string message = "You sould only enter numbers between 1 to 99!";
                string caption = "Invalid group ID";
                if ((MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Error) == MessageBoxResult.OK))
                {
                    obs.GroupIdText = "";
                    obs.NicknameText = "";
                }
                Log.Instance.warn("Invalid input - Invalid ID");//log 
            }
            // checks if the user is already registered or not
            else if (this.chatRoom.register(this.nickname, this.groupId) == false)
            {
                Log.Instance.warn("Invalid input - nickname already exist");//log
                obs.LblRegErrorVisibility = "Hidden";
                MessageBox.Show("Nickname: " + nickname + " already exists in group " + groupId + ", please choose another nickname", "Invalid name", MessageBoxButton.OK, MessageBoxImage.Error);
                obs.GroupIdText = "";
                obs.NicknameText = "";
            }
            // if the user is resigtered 
            else
            { // if the inputs are correct                
                    obs.GroupIdText = "";
                    obs.NicknameText = "";
                    obs.LblAddLoginVisibility = "Visible";
                    obs.LblAddLoginContent = "Now that you are registered:";
                    obs.BtnLoginVisibility = "Visible";

                    Log.Instance.info("New registration - User: " + nickname);//log
                
            }
        }

        private void TxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            obs.BtnRegIsEnabled = !string.IsNullOrEmpty(obs.NicknameContent)
                && !string.IsNullOrEmpty(obs.GroupIdContent);
            obs.LblAddLoginVisibility = "Hidden";
            obs.LblAddLoginContent = "";
            obs.BtnLoginVisibility = "Hidden";
            this.nickname = obs.NicknameContent;
            this.groupId = obs.GroupIdContent;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Log.Instance.info("Registration window closed");

            LoginWindow login = new LoginWindow(this.mainWindow, this.chatRoom, obs);
            this.Close();
            login.Show();
        }

    }
}