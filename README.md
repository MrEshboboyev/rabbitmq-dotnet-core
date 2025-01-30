# 📬 Newsletter System – Send & Receive Apps with AWS 🚀  

This repository contains two powerful **console applications**, **Send** and **Receive**, that work together to **handle messaging efficiently**. Built with **.NET**, **AWS**, **RabbitMQ**, and **PostgreSQL**, this system leverages **event-driven architecture** to ensure scalable, real-time message processing.  

## 🌟 Key Features  

✅ **Send & Receive Console Apps** – Dedicated applications for sending and processing messages.  
✅ **AWS Integration** – Communicates with AWS services for cloud-based message handling.  
✅ **RabbitMQ Messaging** – Ensures asynchronous, reliable message queuing.  
✅ **Event-Driven Architecture** – Decouples services for better scalability and maintainability.  
✅ **EF Core + PostgreSQL** – Provides efficient and structured data persistence.  

---

## 🛠 How It Works  

### **1️⃣ The Send Application**  
- Generates and sends messages to **RabbitMQ**.  
- Stores relevant data in **PostgreSQL via EF Core**.  
- Publishes events for further processing.  

### **2️⃣ The Receive Application**  
- Listens for messages from **RabbitMQ**.  
- Processes and stores the data in **PostgreSQL**.  
- Ensures **fault tolerance** and **retry mechanisms** for reliability.  

---

## 📂 Technologies Used  

🔹 **.NET Core** – Cross-platform application development.  
🔹 **AWS** – Cloud-based infrastructure support.  
🔹 **RabbitMQ** – Message broker for asynchronous event processing.  
🔹 **EF Core** – ORM for PostgreSQL database interaction.  
🔹 **PostgreSQL** – Reliable and scalable relational database.  
🔹 **Console Applications** – Lightweight, high-performance message handlers.  

---

## 🚀 Getting Started  

### **Prerequisites**  
Before running the application, make sure you have:  
✅ **.NET SDK** installed  
✅ **RabbitMQ** running locally or on AWS  
✅ **PostgreSQL** database set up  
✅ **AWS credentials** configured (if needed)  

### **Step 1: Clone the Repository**  
```bash  
git clone https://github.com/MrEshboboyev/rabbitmq-dotnet-core
cd newsletter  
```  

### **Step 2: Configure RabbitMQ & PostgreSQL**  
- Ensure RabbitMQ is running on **localhost:5672** or update the connection string in `appsettings.json`.  
- Create a PostgreSQL database and update the connection string in the project.  

### **Step 3: Run the Applications**  

**Start the Send Application**  
```bash  
dotnet run --project src/Send  
```  

**Start the Receive Application**  
```bash  
dotnet run --project src/Receive
```  

Now, messages sent via **SendApp** will be processed by **ReceiveApp** in real-time!  

---

## 🧪 Testing & Reliability  

The system includes:  
✅ **Retry Mechanisms** – Messages are reprocessed in case of failure.  
✅ **Logging & Monitoring** – Tracks messages and failures efficiently.  
✅ **Database Persistence** – Ensures messages are stored and retrieved securely.  

---

## 🔥 Why Use This System?  

✅ **Asynchronous & Scalable** – Handles high message loads efficiently.  
✅ **Cloud-Ready** – Seamless AWS integration for deployment.  
✅ **Resilient & Fault-Tolerant** – Uses RabbitMQ to prevent data loss.  
✅ **High Performance** – Optimized for event-driven architectures.  

---

## 🏗 About the Author  
This project was developed by [MrEshboboyev](https://github.com/MrEshboboyev), a **.NET expert** specializing in **event-driven systems and scalable architectures**.  

## 📄 License  
This project is licensed under the **MIT License**. Feel free to use and contribute!  

---

🚀 **Ready to build scalable, cloud-powered message processing systems?** Clone the repo and start now!  
