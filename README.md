# FlashWise: Smart Flashcard and Quiz Learning System with Progress Tracking and Pomodoro Timer


## Project Description and Purpose
FlashWise is a Smart Flashcard and Quiz Learning System developed using C# Windows Forms Application. The system is designed to help students improve their study habits, learning efficiency, and time management through interactive learning tools.

The application combines flashcards, quizzes, progress tracking, and a Pomodoro timer into a single platform to promote active recall, spaced repetition, and focused studying. Users can create and manage study materials, take quizzes, monitor their learning progress, and manage study sessions effectively.

The system aims to address common academic problems such as ineffective studying, poor organization of learning materials, lack of time management, and difficulty retaining information.

This project is developed as a requirement for CS 222 – Advanced Object-Oriented Programming.

---

# Purpose of the System

The main purpose of the system is to:

- Help students organize their study materials efficiently
- Improve knowledge retention through flashcards and quizzes
- Encourage active recall and self-assessment
- Provide progress tracking for learning performance
- Support time management using the Pomodoro Technique
- Apply Object-Oriented Programming principles in a real-world application

---

# UML Diagram

## Planned Classes

### Main Classes
- User
- Flashcard
- Quiz
- MultipleChoiceQuiz
- IdentificationQuiz
- ProgressTracker
- PomodoroTimer
- QuizResult
- SubjectCategory

## OOP Principles Applied

### Encapsulation
Data such as usernames, passwords, flashcards, quiz results, and progress are stored securely using private fields with controlled access through methods.

### Inheritance
Different quiz types inherit from the base `Quiz` class:
- MultipleChoiceQuiz
- IdentificationQuiz

### Polymorphism
The method `CheckAnswer()` behaves differently depending on the quiz type.

### Abstraction
Complex processes such as scoring systems, timer logic, and flashcard navigation are hidden behind user-friendly interfaces.

---

# Features and Functionalities

## 1. User Authentication System
- User registration
- User login/logout

## 2. Flashcard Management (CRUD)
- Create flashcards
- View flashcards
- Update flashcards
- Delete flashcards
- Organize flashcards by subject/category

## 3. Flashcard Study System
- Flashcard status:
  - Mastered (Checkbox)

## 4. Quiz Setup
- Take quizzes
- Can choice number of Items
- Can choice type of quiz

## 5. Quiz Types
- Multiple Choice
- Identification

## 6. Score System
- Displays:
  - Score
  - Correct answer
  - Incorrect answer

## 7. Progress Tracking System
Tracks learning progress through:
- Mastery Percentage

## 8. Pomodoro Timer
- 25-minute study sessions
- 5-minute break sessions
- Custom timer support

## 9. Import and Export Premade Decks
- Users can import premade flashcard decks into the system
- Users can export their own flashcard decks for backup or sharing
- Supports organized study material sharing between users
- Helps reduce the time needed to manually create flashcards
- Imported decks are automatically categorized by subject or topic

---

# Explanation of How the Program Works

## Step 1: User Authentication
Users create an account or log in using their credentials.

## Step 2: Dashboard Access
After login, users are redirected to the main dashboard where they can access:
- Flashcards
- Quiz System
- Pomodoro Timer

## Step 3: Flashcard Learning
Users create flashcards and study them through flip-card interaction and keyboard navigation.

The system tracks flashcard progress by checking the Mastered checkbox

## Step 4: Quiz Setup
Users can start quizzes base on their flashcards. Users can also select the quiz type and number of items.

## Step 5: Progress Tracking
The system monitors user learning performance and flashcard progress.

## Step 6: Pomodoro Timer
Users can start study sessions using the Pomodoro Timer while reviewing flashcards or taking quizzes. 

## Step 7: Import and Export Decks
Users can import premade flashcard decks to quickly access study materials without manually creating flashcards.

The system also allows users to export their own flashcard decks for:
- Backup purposes
- Sharing with classmates
- Reusing study materials in the future

Imported decks are automatically added to the flashcard management system and categorized properly for easier studying.

---

# Technologies Used

| Technology | Purpose |
|------------|---------|
| C# | Main programming language |
| Windows Forms | Graphical User Interface |
| Visual Studio | Development environment |
| SQLite / SQL Server | Database management |
| GitHub | Version control and repository hosting |

---

# Instructions on How to Run the Application

## Requirements
- Windows Operating System
- Visual Studio 2022 or later
- .NET Framework

# How to Run the Application

1. Download or clone the repository:

```bash
git clone https://github.com/yourusername/studysync.git
```

2. Open the project folder in Visual Studio.

3. Open the solution file:

```text
StudySync.sln
```

4. Build the project by clicking:

```text
Build → Build Solution
```

5. Run the application by pressing:

```text
F5
```

6. Register an account and start using the system.


# Developers

## Team Name: ENIGM4

| Name | Role | Responsibility |
|------|------|------|
| Berana, Jon Paul S. | Front-End Developer | User Interface Design and Navigation |
| De Castro, Vinz Gabriel S. | Back-End Developer | System Logic and Database Integration |
| De Castro, Vinz Gabriel S. | Documentation Developer | Project Documentation and Repository Management |
| Mendoza, John Laurence M. | Project Manager | Project Coordination, READme file Coordinator, and Testing |

---

# Acknowledgment

The developers would like to express their gratitude to the College of Informatics and Computing Sciences and to our instructor, Ms. Fatima Marie P. Agdon, for the guidance, support, and knowledge provided throughout the development of this project.

This project was developed as a requirement for:

**CS 222 – Advanced Object-Oriented Programming**  
2nd Semester, AY 2025–2026

