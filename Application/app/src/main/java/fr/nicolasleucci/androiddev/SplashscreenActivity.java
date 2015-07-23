package fr.nicolasleucci.androiddev;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.view.Menu;
import android.widget.Toast;

public class SplashscreenActivity extends Activity {

    // Durée du splashscreen
    private final int SPLASH_DISPLAY_LENGTH = 2000;
    private boolean Service_Google = true;
    private boolean WebService = true;

    private boolean Verif_Service(){

        // Vérification à faire

        return true;
    }

    @Override
    public void onCreate(Bundle icicle) {
        super.onCreate(icicle);
        setContentView(R.layout.activity_splashscreen);

        new Handler().postDelayed(new Runnable(){
            @Override
            public void run() {

                // Les services sont OK
                if(Verif_Service()){
                    Intent redirect = new Intent(SplashscreenActivity.this, LoginActivity.class);
                    SplashscreenActivity.this.startActivity(redirect);
                    SplashscreenActivity.this.finish();
                } else {
                    Toast.makeText(SplashscreenActivity.this, "Une erreur est survenue dans le démarrage des services. Veuillez réessayer.", Toast.LENGTH_SHORT).show();
                }


            }
        }, SPLASH_DISPLAY_LENGTH);
    }
}