package fr.nicolasleucci.androiddev;

import android.content.Intent;
import android.os.Bundle;
import android.support.v4.view.GestureDetectorCompat;
import android.support.v7.app.AppCompatActivity;
import android.view.GestureDetector;
import android.view.MotionEvent;
import android.widget.GridView;
import android.widget.Toast;

/**
 * Created by Nico on 18/06/2015.
 */
public class LivresActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_livres);

        GridView gridView = (GridView) findViewById(R.id.gridView);
        gridView.setAdapter(new LivresAdapter(this));

    }

}
