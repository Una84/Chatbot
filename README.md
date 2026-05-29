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

# Author
Phungo Unarine

This project includes chatbot code developed for a Cybersecurity Awareness educational application.
