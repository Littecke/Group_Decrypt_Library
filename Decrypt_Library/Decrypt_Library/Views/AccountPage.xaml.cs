﻿using Decrypt_Library.EntityFrameworkCode;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Decrypt_Library.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountPage : ContentPage
    {
        public AccountPage()
        {
            InitializeComponent();
            // User = user;
        }

        private void MyProfile_Clicked(object sender, EventArgs e)
        {
            profile.IsVisible = true;
            loanHistoryList.IsVisible = false;
            reservations.IsVisible = false;


            profileText.Text = MyPages.UserProfile();
        }

        private void MyLoan_Clicked(object sender, EventArgs e)
        {
            loanList.IsVisible = true;
            profile.IsVisible = false;
            reservations.IsVisible = false;
            loanList.ItemsSource = MyPages.LoanList();
        }

        private void MyReservations_Clicked(object sender, EventArgs e)
        {
            loanList.IsVisible = false;
            profile.IsVisible = false;
            reservations.IsVisible = true;

            reservations.ItemsSource = EntityframeworkBookHistory.ShowUserReservations();
        }

        private void MyLoanHistory_Clicked(object sender, EventArgs e)
        {
            loanList.IsVisible = false;
            profile.IsVisible = false;
            reservations.IsVisible = false;
            loanHistoryList.IsVisible = true;
            loanHistoryList.ItemsSource = MyPages.MyLoanHistory();
        }

        private void RemoveButton_Clicked(object sender, EventArgs e)
        {

            loanList.IsVisible = false;
            profile.IsVisible = false;
            loanHistoryList.IsVisible = false;
            reservations.IsVisible = true;

            Button btn = sender as Button;
            MyPagesProductList reserveList = btn.BindingContext as MyPagesProductList;
            EntityframeworkProducts.DeleteReservation(reserveList.ID);
        }
    }
}