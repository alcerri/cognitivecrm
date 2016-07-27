using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CognitiveCrmMobile.Core.Model;
using CognitiveCrmMobile.Core.Service;
using CognitiveCrmMobile.Utility;

namespace CognitiveCrmMobile
{
    [Activity(Label = "Card Detail", Icon = "@drawable/crm_apps_icon_hi_contrast_32x32")]
    public class CardDetailActivity : Activity
    {
        private ImageView cardImageView;
        private Button reviewButton;
        private Button saveButton;
        private Button cancelButton;
        private TextView nameTextView;
        private TextView phoneNumber1TextView;
        private TextView phoneNumber2TextView;
        private TextView companyNameTextView;
        private TextView addressLine1TextView;
        private TextView addressLine2TextView;
        private TextView addressLine3TextView;
        private TextView emailAddress1TextView;
        private TextView emailAddress2TextView;
        private TextView webSiteTextView;
        private TextView designationTextView;
        private TextView ignoreTextTextView;
        private TextView nameDesignationTextView;
        private TextView phoneNumber1PhoneNumber2TextView;

        private Card selectedCard;
        private CardsDataService dataService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CardDetailView);
            this.dataService = new CardsDataService();
            this.selectedCard = dataService.GetCardById(1);

            FindViews();
            BindData();
            HandleEvents();
        }

        private void FindViews()
        {
            this.cardImageView = FindViewById<ImageView>(Resource.Id.cardImageView);
            this.reviewButton = FindViewById<Button>(Resource.Id.reviewButton);
            this.saveButton = FindViewById<Button>(Resource.Id.saveButton);
            this.cancelButton = FindViewById<Button>(Resource.Id.cancelButton);
            this.nameTextView = FindViewById<TextView>(Resource.Id.nameTextView);
            this.phoneNumber1TextView = FindViewById<TextView>(Resource.Id.phoneNumber1TextView);
            this.phoneNumber2TextView = FindViewById<TextView>(Resource.Id.phoneNumber2TextView);
            this.companyNameTextView = FindViewById<TextView>(Resource.Id.companyNameTextView);
            this.addressLine1TextView = FindViewById<TextView>(Resource.Id.addressLine1TextView);
            this.addressLine2TextView = FindViewById<TextView>(Resource.Id.addressLine2TextView);
            this.addressLine3TextView = FindViewById<TextView>(Resource.Id.addressLine3TextView);
            this.emailAddress1TextView = FindViewById<TextView>(Resource.Id.emailAddress1TextView);
            this.emailAddress2TextView = FindViewById<TextView>(Resource.Id.emailAddress2TextView);
            this.webSiteTextView = FindViewById<TextView>(Resource.Id.webSiteTextView);
            this.designationTextView = FindViewById<TextView>(Resource.Id.designationTextView);
            this.ignoreTextTextView = FindViewById<TextView>(Resource.Id.ignoreTextTextView);
            this.nameDesignationTextView = FindViewById<TextView>(Resource.Id.nameDesignationTextView);
            this.phoneNumber1PhoneNumber2TextView = FindViewById<TextView>(Resource.Id.phoneNumber1PhoneNumber2TextView);
        }

        private void BindData()
        {
            this.nameTextView.Text = this.selectedCard.name;
            this.phoneNumber1TextView.Text = this.selectedCard.phoneNumber1;
            this.phoneNumber2TextView.Text = this.selectedCard.phoneNumber2;
            this.companyNameTextView.Text = this.selectedCard.companyName;
            this.addressLine1TextView.Text = this.selectedCard.addressLine1;
            this.addressLine2TextView.Text = this.selectedCard.addressLine2;
            this.addressLine3TextView.Text = this.selectedCard.addressLine3;
            this.nameDesignationTextView.Text = this.selectedCard.nameDesignation;
            this.emailAddress1TextView.Text = this.selectedCard.emailAddress1;
            this.emailAddress2TextView.Text = this.selectedCard.emailAddress2;
            this.webSiteTextView.Text = this.selectedCard.webSite;
            this.designationTextView.Text = this.selectedCard.designation;
            this.ignoreTextTextView.Text = this.selectedCard.ignoreText;
            this.nameDesignationTextView.Text = this.selectedCard.nameDesignation;
            this.phoneNumber1PhoneNumber2TextView.Text = this.selectedCard.phoneNumber1PhoneNumber2;

            var imageBitmap = ImageHelper.GetImageBitmapFromUrl("http://gillcleerenpluralsight.blob.core.windows.net/files/" + selectedCard.imagePath +".jpg" );
            cardImageView.SetImageBitmap(imageBitmap);
        }

        private void HandleEvents()
        {
            saveButton.Click += SaveButton_Click;
            cancelButton.Click += CancelButton_Click;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var dialog = new AlertDialog.Builder(this);
            dialog.SetTitle("Confirmation");
            dialog.SetMessage("Are you sure you want to save to CRM");
            dialog.Show();
        }
    }
}