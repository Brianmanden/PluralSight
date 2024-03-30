﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

using StockAnalyzer.Core;
using StockAnalyzer.Core.Domain;

namespace StockAnalyzer.Windows;

public partial class MainWindow : Window
{
	private static string API_URL = "https://ps-async.fekberg.com/api/stocks";
	private Stopwatch stopwatch = new Stopwatch();

	public MainWindow()
	{
		InitializeComponent();
	}

	private async void Search_Click(object sender, RoutedEventArgs e)
	{
		try
		{
			BeforeLoadingStockData();

			await GetStocks();
		}
		catch (Exception ex)
		{
			Notes.Text = ex.Message;
		}
		finally
		{
			AfterLoadingStockData();
		}
	}

	private async Task GetStocks()
	{
		try
		{
			DataStore store = new DataStore();
			Task<IList<StockPrice>> responseTask = store.GetStockPrices(StockIdentifier.Text);

			Stocks.ItemsSource = await responseTask;
		}
		catch (Exception ex)
		{
			Notes.Text = ex.Message;
		}
	}

	private void BeforeLoadingStockData()
	{
		stopwatch.Restart();
		StockProgress.Visibility = Visibility.Visible;
		StockProgress.IsIndeterminate = true;
	}

	private void AfterLoadingStockData()
	{
		StocksStatus.Text = $"Loaded stocks for {StockIdentifier.Text} in {stopwatch.ElapsedMilliseconds}ms";
		StockProgress.Visibility = Visibility.Hidden;
	}

	private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
	{
		Process.Start(new ProcessStartInfo { FileName = e.Uri.AbsoluteUri, UseShellExecute = true });

		e.Handled = true;
	}

	private void Close_OnClick(object sender, RoutedEventArgs e)
	{
		Application.Current.Shutdown();
	}
}