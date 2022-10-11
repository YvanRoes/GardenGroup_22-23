using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using MongoDB.Driver;
using Model;
using Logic;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        void Start()
        {
            Databases dbs = new Databases();
            foreach (var db in dbs.Get_All_Databases())
                listBox1.Items.Add(db.name);
            //sup Andy
        }
    }
}
