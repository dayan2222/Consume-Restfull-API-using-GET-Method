# Consume-Restfull-API-using-GET-Method
Consume Restfull API using GET Method

Code Snippet 

            // Calling a web link
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://example_domani.com/?user=USERNAME&pwd=PASSWORD&sender=USERNAME&reciever=YOURNUMBER&msg-data=MESSAGAE&response=json");
            
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            // Display the Content in textbox
            textBox1.Text = textBox1.Text + response.StatusDescription;
            textBox1.Text = textBox1.Text + responseFromServer;
