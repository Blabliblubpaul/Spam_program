using System;

namespace Spam_progam {
    class Spam {
        public static void Main() {
            int counter = 0;
            string text = "#########";
            for (int i = 0; i < 10; i++) {
                text += text;
            }
            while (true) {
                for (int i = 0; i < 1000; i++) {
                    File.AppendAllText($"test{counter}.txt", text);
                }
                File.SetAttributes($"test{counter}.txt", FileAttributes.ReadOnly);
                File.SetAttributes($"test{counter}.txt", FileAttributes.Hidden);
                if (counter >= 5) {
                    break;
                }
                counter++;
            }
        }
    }
}