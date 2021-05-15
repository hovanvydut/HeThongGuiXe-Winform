﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongGiuXe.BLL;

namespace HeThongGiuXe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoginRequire();

        }
        private void LoginRequire()
        {
            if (!Session.HasUser())
            {
                // Show login form
                LoginForm form = new LoginForm();
                this.Hide();
                form.ShowDialog();
                // Check if login success
                if (!Session.HasUser())
                {
                    System.Environment.Exit(1);
                }
                // Show main if login sucess
                this.lbFullname.Text = Session.GetCurrentUser().fullname;
                HideNotAllowFeature();
                this.Show();
            }
        }
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loading.Start(this);
            CheckinForm form = new CheckinForm();
            Loading.Close();
            form.ShowDialog(this);
            this.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loading.Start(this);
            CheckoutForm form = new CheckoutForm();
            Loading.Close();
            form.ShowDialog(this);
            this.Show();
        }

        private void btnGeneralManagement_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //GeneralManagement form = new GeneralManagement();
            //form.ShowDialog(this);
            //this.Show();
        }

        private void btnParkingManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageVehicle form = new ManageVehicle();
            form.ShowDialog(this);
            this.Show();
        }

        private void btnManageManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmployeeForm form = new ManageEmployeeForm();
            form.ShowDialog(this);
            this.Show();
        }

        private void btnUnitPrice_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUnitPrice form = new ManageUnitPrice();
            form.ShowDialog(this);
            this.Show();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveCurrentUser();
            LoginRequire();
        }
        private void HideNotAllowFeature()
        {
            string role = Session.GetCurrentUser().Role.code;
            if (Session.GetCurrentUser() == null) return;
            this.btnCheckin.Enabled = this.btnCheckout.Enabled = role == "employee" ||  role == "admin";
            this.btnParkingManagement.Enabled = role == "employee" || role == "manager" || role == "admin";
            this.btnUnitPrice.Enabled = role == "manager" || role == "admin";
            this.btnGeneralManagement.Enabled = role == "manager" || role == "admin";
            this.btnManageManager.Enabled = role == "admin";
        }
    }
}
