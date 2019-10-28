/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
namespace uncolored.controllers
{
	using FXML = javafx.fxml.FXML;
	using Initializable = javafx.fxml.Initializable;
	using LineChart = javafx.scene.chart.LineChart;

	public class CurrentController : Initializable
	{

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @FXML private javafx.scene.chart.LineChart<String, String> linechart;
		private LineChart<string, string> linechart;

		public override void initialize(URL url, ResourceBundle rb)
		{
		}
	}

}