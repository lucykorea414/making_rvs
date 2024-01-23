using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace WpfApp;

public partial class MainWindow : Window, IComponentConnector
{
	public enum State
	{
		admin,
		user
	}

	private State state = State.admin;

	public MainWindow()
	{
		InitializeComponent();
	}

	private void adminCheckBox_Checked(object sender, RoutedEventArgs e)
	{
		if (state == State.admin)
		{
			TextBox textBox = logTextBox;
			textBox.Text = textBox.Text + Environment.NewLine + "you are admin :)";
			adminCheckBox.IsChecked = true;
			adminCheckBox.IsEnabled = false;
		}
		else
		{
			TextBox textBox2 = logTextBox;
			textBox2.Text = textBox2.Text + Environment.NewLine + "you are not admin!! only admin is allowed.";
			adminCheckBox.IsChecked = false;
			adminCheckBox.IsEnabled = false;
		}
	}

	private void getFlagButton_Click(object sender, RoutedEventArgs e)
	{
		if (state == State.admin && adminCheckBox.IsChecked == true)
		{
			TextBox textBox = logTextBox;
			textBox.Text = textBox.Text + Environment.NewLine + "Success!";
		}
		else
		{
			TextBox textBox2 = logTextBox;
			textBox2.Text = textBox2.Text + Environment.NewLine + "only admin is allowed :p";
		}
	}
}
