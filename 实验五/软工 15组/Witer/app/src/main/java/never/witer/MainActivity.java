package never.witer;

import android.content.Context;
import android.net.wifi.WifiInfo;
import android.net.wifi.WifiManager;
import android.os.Handler;
import android.os.Message;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.DataInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.net.InetSocketAddress;
import java.net.NetworkInterface;
import java.net.Socket;

public class MainActivity extends AppCompatActivity {

    private Socket socket = null;
    private InputStream serverInputStream = null;
    private EditText edtNumber = null;
    private EditText edtName = null;
    private TextView tvwInfo = null;
    private TextView tvwReturnMessage = null;
    private Button btnSendMessage = null;
    private Button btnConnect = null;
    private Handler freshHander = new Handler(){
        @Override
        public void handleMessage(Message msg) {
            switch(msg.what){
                case 0: //设置标题
                    tvwInfo.setText(msg.getData().getString("info"));
                    break;
                case 1:  //设置返回信息
                    tvwReturnMessage.setText(msg.getData().getString("return"));
                    break;
                default:
                    //do something
                    break;
            }
        }
    };
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        edtNumber = (EditText)findViewById(R.id.edtNumber);
        edtName = (EditText)findViewById(R.id.edtName);
        tvwInfo = (TextView)findViewById(R.id.tvwInfo);
        tvwReturnMessage = (TextView)findViewById(R.id.tvwReturnMessage);
        btnConnect = (Button)findViewById(R.id.btnConnect);
        btnConnect.setOnClickListener(new Button.OnClickListener() {
            @Override
            public void onClick(View view) {
                new Thread(new Runnable() {
                    @Override
                    public void run() {
                        try{
                            socket = new Socket();
                            socket.connect(new InetSocketAddress("172.17.68.221", 5000), 5000);
                            Thread.sleep(1000);
                            {
                                //获取信息
                                serverInputStream = socket.getInputStream();
                                BufferedReader buffer = new BufferedReader(new InputStreamReader(socket.getInputStream()));
                                /*int amount = serverInputStream.available();
                                byte[] result = new byte[amount];
                                serverInputStream.read(result);
                                bundle.putString("info", new String(result , "gb2312"));*/
                                Message message = new Message();
                                message.what = 0;
                                Bundle bundle = new Bundle();
                                bundle.putString("info", buffer.readLine());
                                message.setData(bundle);
                                freshHander.sendMessage(message);
                            }
                            {
                                Message message = new Message();
                                message.what = 1;
                                Bundle bundle = new Bundle();
                                bundle.putString("return", "success");
                                message.setData(bundle);
                                freshHander.sendMessage(message);
                            }
                        }catch (Exception e) {
                            {
                                Message message = new Message();
                                message.what = 1;
                                Bundle bundle = new Bundle();
                                bundle.putString("return", e.getMessage());
                                message.setData(bundle);
                                freshHander.sendMessage(message);
                            }
                        }
                    }
                }).start();
            }
        });


        btnSendMessage = (Button)findViewById(R.id.btnSendMessage);
        btnSendMessage.setOnClickListener(new Button.OnClickListener() {
            @Override
            public void onClick(View view) {
                if( socket.isConnected()){
                    new Thread(new Runnable() {
                        @Override
                        public void run() {
                            try {
                                PrintWriter out = new PrintWriter(new BufferedWriter(new OutputStreamWriter(socket.getOutputStream())), true);
                                WifiManager wifi = (WifiManager)getSystemService(Context.WIFI_SERVICE);
                                WifiInfo wifiInfo = wifi.getConnectionInfo();
                                out.println(edtNumber.getText().toString() + "," + edtName.getText().toString() + "," + wifiInfo.getMacAddress() );
                                /*if (socket.isClosed() == false) {
                                    socket.close();
                                }*/
                            } catch (Exception e) {
                            }
                        }
                    }).start();
                }
            }
        });
    }
}
