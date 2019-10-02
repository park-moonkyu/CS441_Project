﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CarTracker.Models;
using Xamarin.Forms;

namespace CarTracker {
    public partial class YourCarsPage : ContentPage {
        public static ObservableCollection<Car> Cars = new ObservableCollection<Car>();
        public YourCarsPage() {
            InitializeComponent();
            yourCarsList.ItemsSource = Cars;
        }


        private void AddNewCarClicked(object sender, System.EventArgs e) {
            popupLoginView.IsVisible = true;
        }

        private void ConfirmNewCar(object sender, System.EventArgs e) {
            Car newCar = new Car(plate.Text, make.Text, model.Text, Models.Color.Gray, vin.Text, name.Text);
            Cars.Add(newCar);
            popupLoginView.IsVisible = false;
            testLabel.Text = "Total Cars: " + Cars.Count.ToString();
            ClearEntryFields();
        }

        private void ClearEntryFields() {
            plate.Text = null;
            make.Text = null;
            model.Text = null;
            carColor.Text = null;
            vin.Text = null;
            name.Text = null;
        }

        private void OnSortClicked(object sender, System.EventArgs e) {
            SortByPlate();
        }

        private void SortByPlate() {
            //Cars.Sort();
        }
        private void SortByMake() {

        }
        private void SortByModel() {

        }
        private void SortByColor() {

        }
        private void SortByVin() {

        }
        private void SortByName() {

        }
        private void ReverseSort() {

        }
    }
}