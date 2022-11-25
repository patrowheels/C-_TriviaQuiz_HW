using System;

class Question {
    private string text = "";
    private string[] answers;
    private int correct = 0;

    public Question(string text, string[] answers, int correct) {
        this.text = text;
        this.answers = answers;
        this.correct = correct;
    }

    public string getText(){
        return text;
    }

    public string[] getAnswers(){
        return answers;
    }

    public int getCorrect(){
        return correct;
    }
}

class MainClass {
  public static void Main (string[] args) {

    string[] answers = {
        "The Legend of Mario", 
        "Samus",
        "Kirby", 
        "Zelda"
    };

    string[] q2_answers = {"2", "4","6", "8","10","12"};
    string[] q3_answers = {"Hulk", "Pinocchio","Peter Pan"};

    Question q1 = new Question("Which game is Link from?", answers, 3);
    Question q2 = new Question("How many legs does a spider have?", q2_answers, 3);
    Question q3 = new Question("Whose nose grew longer every time he lied?", q3_answers, 2);

    // Instantiate random number generator 
		Random rand = new Random(); 

    int number = rand.Next(1,4);
    Console.WriteLine(number);

    if(number == 1)
      displayQuestion(q1);
    else if (number == 2)
      displayQuestion(q2);
    else
      displayQuestion(q3);

  }

  static void displayQuestion(Question Q)
  {
      Console.WriteLine(Q.getText());
      string[] answer_choices = Q.getAnswers();
      
      // Create a loop to write each answer into the console
      for(int i = 0; i < answer_choices.Length; ++i)
          Console.WriteLine("{0}: {1}", i, answer_choices[i]);

      char choice = Console.ReadLine()[0];

      if (choice >= '0' && choice <= '5')
      {
          int numChoice = (int)Char.GetNumericValue(choice);
          
          if(numChoice == Q.getCorrect())
              Console.WriteLine("CORRECT!");
          else 
              Console.WriteLine("WRONG!");
      }
  }
}