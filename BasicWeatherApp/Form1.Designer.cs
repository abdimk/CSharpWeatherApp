namespace BasicWeatherApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hourly_panel = new System.Windows.Forms.Panel();
            this.daily_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.current_w_image = new System.Windows.Forms.PictureBox();
            this.current_w_temp = new System.Windows.Forms.Label();
            this.apparent_temp = new System.Windows.Forms.Label();
            this.current_w_desc = new System.Windows.Forms.Label();
            this.humidity_label = new System.Windows.Forms.Label();
            this.rain_label = new System.Windows.Forms.Label();
            this.drewpoint_label = new System.Windows.Forms.Label();
            this.snowfal_label = new System.Windows.Forms.Label();
            this.windspeed_label = new System.Windows.Forms.Label();
            this.visibility_label = new System.Windows.Forms.Label();
            this.current_humidity = new System.Windows.Forms.Label();
            this.current_wind_speed = new System.Windows.Forms.Label();
            this.current_panel = new System.Windows.Forms.Panel();
            this.current_drew_point = new System.Windows.Forms.Label();
            this.current_rain = new System.Windows.Forms.Label();
            this.current_snowfall = new System.Windows.Forms.Label();
            this.current_visibility = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.current_w_image)).BeginInit();
            this.current_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hourly_panel
            // 
            this.hourly_panel.AutoScroll = true;
            this.hourly_panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hourly_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hourly_panel.Location = new System.Drawing.Point(12, 261);
            this.hourly_panel.Name = "hourly_panel";
            this.hourly_panel.Size = new System.Drawing.Size(750, 337);
            this.hourly_panel.TabIndex = 1;
            // 
            // daily_panel
            // 
            this.daily_panel.AutoScroll = true;
            this.daily_panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.daily_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daily_panel.Location = new System.Drawing.Point(768, 13);
            this.daily_panel.Name = "daily_panel";
            this.daily_panel.Size = new System.Drawing.Size(729, 585);
            this.daily_panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Weather";
            // 
            // current_w_image
            // 
            this.current_w_image.Location = new System.Drawing.Point(2, 44);
            this.current_w_image.Name = "current_w_image";
            this.current_w_image.Size = new System.Drawing.Size(100, 100);
            this.current_w_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.current_w_image.TabIndex = 1;
            this.current_w_image.TabStop = false;
            // 
            // current_w_temp
            // 
            this.current_w_temp.AutoSize = true;
            this.current_w_temp.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_w_temp.ForeColor = System.Drawing.SystemColors.Control;
            this.current_w_temp.Location = new System.Drawing.Point(3, 145);
            this.current_w_temp.Name = "current_w_temp";
            this.current_w_temp.Size = new System.Drawing.Size(131, 55);
            this.current_w_temp.TabIndex = 2;
            this.current_w_temp.Text = "temp";
            // 
            // apparent_temp
            // 
            this.apparent_temp.AutoSize = true;
            this.apparent_temp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apparent_temp.ForeColor = System.Drawing.SystemColors.Control;
            this.apparent_temp.Location = new System.Drawing.Point(158, 123);
            this.apparent_temp.Name = "apparent_temp";
            this.apparent_temp.Size = new System.Drawing.Size(67, 16);
            this.apparent_temp.TabIndex = 3;
            this.apparent_temp.Text = "add-temp";
            // 
            // current_w_desc
            // 
            this.current_w_desc.AutoSize = true;
            this.current_w_desc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_w_desc.ForeColor = System.Drawing.SystemColors.Control;
            this.current_w_desc.Location = new System.Drawing.Point(156, 75);
            this.current_w_desc.Name = "current_w_desc";
            this.current_w_desc.Size = new System.Drawing.Size(117, 24);
            this.current_w_desc.TabIndex = 4;
            this.current_w_desc.Text = "temp-desc";
            // 
            // humidity_label
            // 
            this.humidity_label.AutoSize = true;
            this.humidity_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity_label.ForeColor = System.Drawing.SystemColors.Control;
            this.humidity_label.Location = new System.Drawing.Point(431, 20);
            this.humidity_label.Name = "humidity_label";
            this.humidity_label.Size = new System.Drawing.Size(58, 16);
            this.humidity_label.TabIndex = 5;
            this.humidity_label.Text = "Humidity";
            // 
            // rain_label
            // 
            this.rain_label.AutoSize = true;
            this.rain_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rain_label.ForeColor = System.Drawing.SystemColors.Control;
            this.rain_label.Location = new System.Drawing.Point(431, 145);
            this.rain_label.Name = "rain_label";
            this.rain_label.Size = new System.Drawing.Size(33, 16);
            this.rain_label.TabIndex = 6;
            this.rain_label.Text = "Rain";
            // 
            // drewpoint_label
            // 
            this.drewpoint_label.AutoSize = true;
            this.drewpoint_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drewpoint_label.ForeColor = System.Drawing.SystemColors.Control;
            this.drewpoint_label.Location = new System.Drawing.Point(431, 85);
            this.drewpoint_label.Name = "drewpoint_label";
            this.drewpoint_label.Size = new System.Drawing.Size(66, 16);
            this.drewpoint_label.TabIndex = 7;
            this.drewpoint_label.Text = "DrewPoint";
            // 
            // snowfal_label
            // 
            this.snowfal_label.AutoSize = true;
            this.snowfal_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snowfal_label.ForeColor = System.Drawing.SystemColors.Control;
            this.snowfal_label.Location = new System.Drawing.Point(618, 85);
            this.snowfal_label.Name = "snowfal_label";
            this.snowfal_label.Size = new System.Drawing.Size(60, 16);
            this.snowfal_label.TabIndex = 8;
            this.snowfal_label.Text = "SnowFall";
            // 
            // windspeed_label
            // 
            this.windspeed_label.AutoSize = true;
            this.windspeed_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windspeed_label.ForeColor = System.Drawing.SystemColors.Control;
            this.windspeed_label.Location = new System.Drawing.Point(618, 20);
            this.windspeed_label.Name = "windspeed_label";
            this.windspeed_label.Size = new System.Drawing.Size(74, 16);
            this.windspeed_label.TabIndex = 9;
            this.windspeed_label.Text = "WindSpeed";
            // 
            // visibility_label
            // 
            this.visibility_label.AutoSize = true;
            this.visibility_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visibility_label.ForeColor = System.Drawing.SystemColors.Control;
            this.visibility_label.Location = new System.Drawing.Point(618, 145);
            this.visibility_label.Name = "visibility_label";
            this.visibility_label.Size = new System.Drawing.Size(56, 16);
            this.visibility_label.TabIndex = 10;
            this.visibility_label.Text = "Visibility";
            // 
            // current_humidity
            // 
            this.current_humidity.AutoSize = true;
            this.current_humidity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_humidity.ForeColor = System.Drawing.SystemColors.Control;
            this.current_humidity.Location = new System.Drawing.Point(431, 46);
            this.current_humidity.Name = "current_humidity";
            this.current_humidity.Size = new System.Drawing.Size(85, 19);
            this.current_humidity.TabIndex = 11;
            this.current_humidity.Text = "[humidity]";
            // 
            // current_wind_speed
            // 
            this.current_wind_speed.AutoSize = true;
            this.current_wind_speed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_wind_speed.ForeColor = System.Drawing.SystemColors.Control;
            this.current_wind_speed.Location = new System.Drawing.Point(618, 46);
            this.current_wind_speed.Name = "current_wind_speed";
            this.current_wind_speed.Size = new System.Drawing.Size(103, 19);
            this.current_wind_speed.TabIndex = 12;
            this.current_wind_speed.Text = "[windspeed]";
            // 
            // current_panel
            // 
            this.current_panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.current_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.current_panel.Controls.Add(this.current_visibility);
            this.current_panel.Controls.Add(this.current_snowfall);
            this.current_panel.Controls.Add(this.current_rain);
            this.current_panel.Controls.Add(this.current_drew_point);
            this.current_panel.Controls.Add(this.current_wind_speed);
            this.current_panel.Controls.Add(this.current_humidity);
            this.current_panel.Controls.Add(this.visibility_label);
            this.current_panel.Controls.Add(this.windspeed_label);
            this.current_panel.Controls.Add(this.snowfal_label);
            this.current_panel.Controls.Add(this.drewpoint_label);
            this.current_panel.Controls.Add(this.rain_label);
            this.current_panel.Controls.Add(this.humidity_label);
            this.current_panel.Controls.Add(this.current_w_desc);
            this.current_panel.Controls.Add(this.apparent_temp);
            this.current_panel.Controls.Add(this.current_w_temp);
            this.current_panel.Controls.Add(this.current_w_image);
            this.current_panel.Controls.Add(this.label1);
            this.current_panel.Location = new System.Drawing.Point(12, 13);
            this.current_panel.Name = "current_panel";
            this.current_panel.Size = new System.Drawing.Size(750, 243);
            this.current_panel.TabIndex = 0;
            // 
            // current_drew_point
            // 
            this.current_drew_point.AutoSize = true;
            this.current_drew_point.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_drew_point.ForeColor = System.Drawing.SystemColors.Control;
            this.current_drew_point.Location = new System.Drawing.Point(431, 104);
            this.current_drew_point.Name = "current_drew_point";
            this.current_drew_point.Size = new System.Drawing.Size(96, 19);
            this.current_drew_point.TabIndex = 13;
            this.current_drew_point.Text = "[drewpoint]";
            // 
            // current_rain
            // 
            this.current_rain.AutoSize = true;
            this.current_rain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_rain.ForeColor = System.Drawing.SystemColors.Control;
            this.current_rain.Location = new System.Drawing.Point(431, 164);
            this.current_rain.Name = "current_rain";
            this.current_rain.Size = new System.Drawing.Size(48, 19);
            this.current_rain.TabIndex = 14;
            this.current_rain.Text = "[rain]";
            // 
            // current_snowfall
            // 
            this.current_snowfall.AutoSize = true;
            this.current_snowfall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_snowfall.ForeColor = System.Drawing.SystemColors.Control;
            this.current_snowfall.Location = new System.Drawing.Point(618, 104);
            this.current_snowfall.Name = "current_snowfall";
            this.current_snowfall.Size = new System.Drawing.Size(83, 19);
            this.current_snowfall.TabIndex = 15;
            this.current_snowfall.Text = "[snowfall]";
            // 
            // current_visibility
            // 
            this.current_visibility.AutoSize = true;
            this.current_visibility.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_visibility.ForeColor = System.Drawing.SystemColors.Control;
            this.current_visibility.Location = new System.Drawing.Point(611, 164);
            this.current_visibility.Name = "current_visibility";
            this.current_visibility.Size = new System.Drawing.Size(81, 19);
            this.current_visibility.TabIndex = 16;
            this.current_visibility.Text = "[visibility]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 622);
            this.Controls.Add(this.daily_panel);
            this.Controls.Add(this.hourly_panel);
            this.Controls.Add(this.current_panel);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Basic Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.current_w_image)).EndInit();
            this.current_panel.ResumeLayout(false);
            this.current_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel hourly_panel;
        private System.Windows.Forms.Panel daily_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox current_w_image;
        private System.Windows.Forms.Label current_w_temp;
        private System.Windows.Forms.Label apparent_temp;
        private System.Windows.Forms.Label current_w_desc;
        private System.Windows.Forms.Label humidity_label;
        private System.Windows.Forms.Label rain_label;
        private System.Windows.Forms.Label drewpoint_label;
        private System.Windows.Forms.Label snowfal_label;
        private System.Windows.Forms.Label windspeed_label;
        private System.Windows.Forms.Label visibility_label;
        private System.Windows.Forms.Label current_humidity;
        private System.Windows.Forms.Label current_wind_speed;
        private System.Windows.Forms.Panel current_panel;
        private System.Windows.Forms.Label current_visibility;
        private System.Windows.Forms.Label current_snowfall;
        private System.Windows.Forms.Label current_rain;
        private System.Windows.Forms.Label current_drew_point;
    }
}

