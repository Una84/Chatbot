# Cybersecurity Awareness Bot

## Description
The Cybersecurity Awareness Bot is a C# application developed to educate users about cybersecurity topics in an interactive and user-friendly way.

This project started as a console-based chatbot in Part 1 and was upgraded in Part 2 into a Windows Forms GUI application with enhanced functionality such as:
- Dynamic chatbot responses
- Sentiment detection
- Memory and recall
- Keyword recognition
- Randomised cybersecurity tips
- Voice greeting
- Improved conversation flow

The chatbot helps users learn about online safety, scams, phishing, password protection, privacy, and general cybersecurity awareness.

In Part 3, the system was extended into a fully interactive cybersecurity learning platform with task management, a quiz system, NLP simulation, and activity tracking using a database-backed architecture.

The chatbot helps users learn about online safety, scams, phishing, password protection, privacy, and general cybersecurity awareness.

---

# Features

## Part 1 Features
- Voice greeting using WAV playback
- ASCII art cybersecurity banner
- User interaction with name personalisation
- Cybersecurity awareness responses
- Input validation
- Styled console interface
- Object-Oriented Programming structure

---

## Part 2 Features

### GUI Interface
- Windows Forms graphical user interface
- User-friendly layout and colours
- Interactive chat window
- Styled buttons and input fields

### Voice Greeting
- Plays greeting audio when application starts

### Keyword Recognition
Recognises cybersecurity-related keywords including:
- Password
- Phishing
- Scam
- Privacy

### Random Responses
Provides random cybersecurity tips using lists and arrays to create more natural conversations.

### Conversation Flow
Supports follow-up interactions such as:
- "Tell me more"
- "Explain more"
- "Give me another tip"

### Memory and Recall
The chatbot remembers:
- User name
- Favourite cybersecurity topic
- Previous conversation topics

Example:
> "I'm interested in privacy."

Later:
> "As someone interested in privacy, remember to review your account security settings regularly."

### Sentiment Detection
Detects simple sentiments such as:
- Worried
- Curious
- Frustrated

The chatbot responds supportively and continues the topic naturally.

### Error Handling
- Prevents crashes on invalid input
- Handles unknown inputs gracefully
- Displays user-friendly messages

### Code Optimisation
Uses:
- Dictionaries
- Lists
- Classes
- Methods
- Encapsulation
- Modular design principles

The project structure is organised for easy future expansion in Part 3/POE.

---

# Technologies Used
- C#
- .NET Windows Forms
- Object-Oriented Programming (OOP)
- System.Media
- GitHub Actions (CI)

---

# Project Structure

```text
CybersecurityAwarenessBot/
│
├── Assets/
│   ├── greeting.wav
│   └── logo.png
│
├── Program.cs
├── MainForm.cs
├── MainForm.Designer.cs
├── ChatbotEngine.cs
├── MemoryManager.cs
├── AudioPlayer.cs
├── README.md
```

---

# How to Run

1. Open the project in Visual Studio
2. Build the solution
3. Ensure the `greeting.wav` file is inside the `Assets` folder
4. Run the application

---

# GUI Preview

## Cybersecurity Awareness Bot Interface
The GUI includes:
- Chat display area
- User input textbox
- Send button
- Styled cybersecurity-themed interface

---

# CI Workflow

<img width="1600" height="443" alt="image" src="https://github.com/user-attachments/assets/94a98da1-96fd-49be-a2d4-ed35d5b1f101" />

---

# GitHub Requirements Completed
- Multiple meaningful commits
- README included
- Multimedia assets included
- Object-oriented code structure
- Ready for future expansion

---

# Future Improvements
- AI-powered chatbot responses
- Database integration
- User authentication
- Advanced sentiment analysis
- Online API integration
- Multi-language support

---

# Part 3 Features (POE FINAL ENHANCEMENTS)

## 🗂 Task Assistant with MySQL Database
A full task management system was added to help users manage cybersecurity-related tasks.

### Features:
- Add cybersecurity tasks
- Store tasks in MySQL database
- View all tasks in GUI
- Delete tasks
- Mark tasks as completed
- Add reminder dates

### Example tasks:
- Enable Two-Factor Authentication
- Update passwords regularly
- Review privacy settings

---

## 🎮 Cybersecurity Quiz Game
A fully interactive quiz system was added to reinforce cybersecurity learning.

### Features:
- 10+ cybersecurity questions
- Multiple-choice and True/False format
- Instant feedback after each answer
- Score tracking system
- Final performance message

### Example feedback:
- Excellent performance
- Good cybersecurity knowledge
- Needs improvement

---

## 🧠 NLP Simulation (Natural Language Processing)
A simulated NLP system was implemented using keyword detection and string matching.

### Features:
- Detects user intent even with different phrasing
- Understands commands like:
  - "Add task"
  - "Create reminder"
  - "Start quiz"
  - "Show activity log"
- Reduces need for exact input formatting

---

## 📊 Activity Log System
An activity tracking system was added to monitor chatbot actions.

### Features:
- Logs all major actions
- Stores timestamps
- Displays last 10 actions
- Tracks:
  - Task creation
  - Quiz attempts
  - Sentiment detection
  - User interactions

---

## 🎨 Enhanced GUI System
The Windows Forms interface was upgraded to include multiple functional panels.

### GUI Includes:
- Chat interface panel
- Task manager panel
- Quiz game panel
- Activity log panel
- Cybersecurity-themed design

---

# Technologies Used
- C#
- .NET Windows Forms
- MySQL Database
- Object-Oriented Programming (OOP)
- Collections (Lists & Dictionaries)
- System.Media (Audio)
- Event-driven programming

---

# Database Setup

Run the following SQL script in MySQL:

```sql
CREATE DATABASE CyberBot;

USE CyberBot;

CREATE TABLE Tasks (
    TaskID INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(100),
    Description TEXT,
    ReminderDate DATETIME,
    Completed BOOLEAN DEFAULT FALSE
);

---

# Author
Phungo Unarine

This project includes chatbot code developed for a Cybersecurity Awareness educational application.
