  
   using System;
   public class Task
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        // Autres propriétés pour la tâche

        // Constructeur par défaut nécessaire si vous souhaitez instancier Task sans paramètres
        public Task()
        {
        }
    }