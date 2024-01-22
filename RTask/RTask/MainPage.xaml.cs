using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RTask
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AddTask_Clicked(object sender, EventArgs e)
        {
            // Create a StackLayout to hold the controls
            StackLayout addTaskLayout = new StackLayout();

            // Create an input box for the task text
            Entry taskEntry = new Entry { Placeholder = "Enter the task text", MaxLength = 50 };

            // Create a Picker with language-specific options
            Picker priorityPicker = new Picker();
            foreach (var option in GetLocalizedPriorityOptions())
            {
                priorityPicker.Items.Add(option);
            }

            // Add controls to the StackLayout
            addTaskLayout.Children.Add(taskEntry);
            addTaskLayout.Children.Add(priorityPicker);

            // Create a "Confirm" button
            Button confirmButton = new Button { Text = "Confirm" };
            confirmButton.Clicked += async (sender2, args) =>
            {
                // Check if text was provided before adding the task
                if (!string.IsNullOrWhiteSpace(taskEntry.Text))
                {
                    // Create a new CheckBox and a Label with the task text
                    CheckBox newCheckBox = new CheckBox();
                    Label newLabel = new Label { Text = taskEntry.Text, VerticalOptions = LayoutOptions.Center };

                    // Handle the CheckedChanged event if necessary
                    newCheckBox.CheckedChanged += (sender3, eventArgs) =>
                    {
                        // Your logic when the checkbox state changes
                    };

                    // Add the CheckBox, Label, and Picker to the StackLayout
                    tasksStackLayout.Children.Add(new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children = { newCheckBox, newLabel, priorityPicker }
                    });

                    // Dismiss the modal
                    await Navigation.PopModalAsync();
                }
            };

            // Add the "Confirm" button to the StackLayout
            addTaskLayout.Children.Add(confirmButton);

            // Create a new ContentPage with the StackLayout as its content
            ContentPage dialogContent = new ContentPage
            {
                Content = addTaskLayout,
                Title = "New Task"
            };

            // Create the dialog page as a modal
            await Navigation.PushModalAsync(new NavigationPage(dialogContent)
            {
                BarBackgroundColor = Color.FromHex("#2196F3"),
                BarTextColor = Color.White
            });
        }

        private List<string> GetLocalizedPriorityOptions()
        {
            // Here you can implement logic to obtain Picker options in the appropriate language
            // In this example, we simply return fixed options in English
            return new List<string> { "Daily", "Weekly", "Monthly", "Annually" };
        }
    }
}
