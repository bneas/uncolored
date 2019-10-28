/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package uncolored.controllers;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.chart.LineChart;

public class CurrentController implements Initializable {

    @FXML
    private LineChart<String, String> linechart;

    @Override
    public void initialize(URL url, ResourceBundle rb) {
    }
}
