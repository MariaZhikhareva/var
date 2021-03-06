﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace var5lab2
{
    class MainWindowViewM:INotifyPropertyChanged
    {
         
        
        public static Int64 NumOfCard { get; set; }
        public static int ID { get; set; }
        public static String Holder { get; set; }

        public static int? CVV { get; set; }
        private Visibility _vis;
        public Visibility Vis
        {
            get { return _vis; }
            set { _vis = value; OnPropertyChanged("Vis"); }
        }
        private Visibility _visCard;
        public Visibility VisCard
        {
            get { return _visCard; }
            set { _visCard = value; OnPropertyChanged("VisCard"); }
        }
        public List<String> Surrender { get; set; }
        public static int SelectedSur { get; set; }

        public List<String> Month { get; set; }
        public static int? SelectedMonth { get; set; }
       
        public List<String> Year { get; set; }
        public static int? SelectedYear { get; set; }

        
        private bool _byCash=true;
        
        public bool ByCash
             
          {
            get { return _byCash; }
    set
            {

                _byCash = value;
                OnPropertyChanged ("ByCash");
                Vis = Visibility.Hidden;
                OnPropertyChanged("Vis");
                VisCard = Visibility.Visible;
                OnPropertyChanged("VisCard");
            }
        }

        private bool _card; 
        public bool Card
        {
            get { return _card; }
            set
            {
                _card = value;
               
                OnPropertyChanged("Card");
                Vis = Visibility.Visible;
                OnPropertyChanged("Vis");
                VisCard = Visibility.Hidden;
                OnPropertyChanged("VisCard");

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string prop = "")
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public static void SaveCardData()
        {
            Card a = new Card(ID, NumOfCard, Holder, SelectedMonth, SelectedYear, CVV);
            MyBDEntities context = new MyBDEntities();
            context.Card.Add(a);
            context.SaveChangesAsync();
        }
        public static void SaveCashData()
        {
            Cash a = new Cash(ID, SelectedSur);
            MyBDEntities context = new MyBDEntities();
            context.Cash.Add(a);
            context.SaveChangesAsync();
        }
        public MainWindowViewM()
        {
            
            VisCard = Visibility.Hidden;
            OnPropertyChanged("VisCard");
            Surrender = new List<string>()
            {
                "5000",
                "10000"
            };

            Month = new List<string>()
            {
                "01",
                "02",
                "03",
                "04",
                "05",
                "06",
                "07",
                "08",
                "09",
                "10",
                "11",
                "12"
            };

            Year = new List<string>()
            {
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                "24",
                "25",
                "26"
            };


        }
    }
}
