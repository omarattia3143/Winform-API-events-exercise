using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using WinFormClient.Models;
using WinFormClient.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormClient
{
    public partial class MainForm : Form
    {
        private IApiService _apiService;
        private Thread _apiThread;
        private List<Listener> _listeners = new List<Listener>();

        public MainForm()
        {
            InitializeComponent();
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            var serverUrl = textBox.Text;
            _apiService = new ApiService(serverUrl);

            // start api thread
            _apiThread = new Thread(_apiService.SendRequest);
            _apiThread.Start();

            // disable button in ui
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // stop api
            _apiThread.Abort();

            // disable stop button in ui
            stopBtn.Enabled = false;
            startBtn.Enabled = true;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            
            var listener = new Listener();

            listener.CounterChanged += ListenerCounterChangedEvent;
            _listeners.Add(listener);
            
            UpdateListView();

            // subscribe listener
            _apiService.PayloadReceived += listener.HandlePayload;
        }

        private void unregisterButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                // get listener
                var selectedListener = _listeners[listView.SelectedItems[0].Index];
                selectedListener.CounterChanged -= ListenerCounterChangedEvent;

                // remove it
                _listeners.Remove(selectedListener);

                // update
                UpdateListView();

                // unsubscribe
                _apiService.PayloadReceived -= selectedListener.HandlePayload;
            }
        }


        private void ListenerCounterChangedEvent(Listener listener)
        {
            if (listView.IsDisposed || listView.FindForm().IsDisposed)
            {
                return;
            }

            if (listView.InvokeRequired)
            {
                listView.Invoke(new Action(() => ListenerCounterChangedEvent(listener)));
                return;
            }

            UpdateListView();
        }

        private void UpdateListView()
        {
            listView.Items.Clear();

            foreach (var listener in _listeners)
            {
                var item = new ListViewItem(new[]
                {
                    listener.Name,
                    listener.Target.ToString(),
                    listener.Counter.ToString()
                });

                listView.Items.Add(item);
            }
        }

    }
    
}