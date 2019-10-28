package uncolored.controllers;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;
import java.util.logging.Level;
import java.util.logging.Logger;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.layout.VBox;

public class NewAnalysisController implements Initializable {

    @FXML
    private VBox vbox;
    private VBox nextFxml;

    @Override
    public void initialize(URL url, ResourceBundle rb) {
        try {
            // TODO
            nextFxml = FXMLLoader.load(getClass().getResource("/uncolored/views/NewAnalysis_1.fxml"));
        } catch (IOException ex) {
            Logger.getLogger(NewAnalysisController.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    @FXML
    private void next(ActionEvent event) {
        vbox.getChildren().clear();
        vbox.getChildren().setAll(nextFxml);
    }

}
