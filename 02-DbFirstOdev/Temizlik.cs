namespace _02_DbFirstOdev
{
    public static class Temizlik
    {
        public static void Clear(Form form)
        {
            foreach (var item in form.Controls)
            {
                if (item is TextBox) ((TextBox)item).Clear();
                else if (item is CheckBox) ((CheckBox)item).Checked = false;
                else if (item is NumericUpDown) ((NumericUpDown)item).Value = 0;
                else if (item is ComboBox) ((ComboBox)item).SelectedIndex = -1;
                //else if (item is GroupBox) Clear(form); Control collection yapısı daha tatlı
            }
        }

    }
}
