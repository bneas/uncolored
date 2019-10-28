package uncolored.controllers;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;
import java.util.logging.Level;
import java.util.logging.Logger;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.HBox;
import javafx.scene.layout.VBox;

/**
 *
 * @author Benny
 */
public class DashboardController implements Initializable {

    @FXML
    private VBox content;

    VBox current, newAnalysis, savedAnalysis, baselineAnalysis, setting;

    @Override
    public void initialize(URL url, ResourceBundle rb) {
        try {
            current = FXMLLoader.load(getClass().getResource("/uncolored/views/Current.fxml"));
            newAnalysis = FXMLLoader.load(getClass().getResource("/uncolored/views/NewAnalysis.fxml"));
            savedAnalysis = FXMLLoader.load(getClass().getResource("/uncolored/views/SavedAnalysis.fxml"));
            baselineAnalysis = FXMLLoader.load(getClass().getResource("/uncolored/views/BaselineAnalysis.fxml"));
            setting = FXMLLoader.load(getClass().getResource("/uncolored/views/Setting.fxml"));
            content.getChildren().setAll(current);

        } catch (IOException ex) {
            Logger.getLogger(DashboardController.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    @FXML
    private void changeContent(MouseEvent event) {
        content.getChildren().removeAll();

        HBox btn = (HBox) ((Node) event.getSource());
        switch (btn.getId()) {
            case "currentRisk":
                content.getChildren().setAll(current);
                break;
            case "nAnalysis":
                content.getChildren().setAll(newAnalysis);
                break;
            case "sAnalysis":
                content.getChildren().setAll(savedAnalysis);
                break;
            case "bAnalysis":
                content.getChildren().setAll(baselineAnalysis);
                break;
            case "setting":
                content.getChildren().setAll(setting);
                break;
        }
    }

}
