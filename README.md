# GlowDesk

A lightweight and elegant Windows Forms application that gives you a better way to access your recent files and folders — faster, customizable, and visually organized using colored labels and emojis.

It asks users to select a directory, and give a threshold value (number of recently used files you want), and then you get recently used color coded files lined in the recentBox. With green : most recently used, yellow : used prior to the most recent, red : last recently used. Also our Forms application gives you the privilege to right click and copy path of all recently used files, and double clicking on it gives you the access to the file.

Auto scan feature is also provided, when selected, it scans the directory every 10 seconds, thus giving you updated and real time results.

Why is it better than Windows Task Bar? 
Windows Task Bar never allows you give a custom diretory and track recently used files, also right click and copy path privilege is not provided. No color coding in the task bar as such in our project.

---

## 🚀 Features

- 📁 List of recent files and folders with full paths
- 🎨 Color-coded entries for easier identification
- 🖼️ Icons: 📁 for folders, 📝 for files, ❓ for missing entries
- ✅ Click to open directly
- 🖱️ Right-click to copy full file/folder path
- 🔄 Automatically refreshes recent entries
- 🧩 Lightweight and portable — no installation required
- 🧠 Custom sort logic — not based on access time only
- 🪟 Always-on-top support, no clutter like the Windows taskbar

---

## 💡 Why is this better than the Windows taskbar?

| Feature | Windows Taskbar | This App |
|--------|------------------|----------|
| Recent file access | 🟥 Limited, no full path | ✅ Full path & more control |
| File type indication | 🟥 Icon only | ✅ Text + Color + Emoji |
| Right-click copy path | 🟥 Not intuitive | ✅ 1-click path copy |
| Always-on-top | ❌ No | ✅ Yes (optional) |
| Lightweight | ❌ Heavy Explorer usage | ✅ Minimal memory footprint |

---

## 🔧 Installation & Setup Instructions

### 🖥️ Requirements
- OS: Windows 10 or 11
- IDE: [Visual Studio 2022 or later](https://visualstudio.microsoft.com/downloads/)
- Workload: **.NET Desktop Development**

### ✅ Step-by-step to Run the Project

1. **📦 Clone the repository**
    ```bash
    git clone https://github.com/bhaskar6858/GlowDesk--Smart-Highlight
    cd recent-launcher
    ```

2. **🔨 Open the project in Visual Studio**
    - Launch **Visual Studio**
    - Go to `File` → `Open` → `Project/Solution`
    - Open `Glowdesk.sln`

3. **🛠️ If prompted, install the required workload**
    - Select **.NET Desktop Development** (this includes Windows Forms support)
    - You can also install this via **Visual Studio Installer** → Modify → Check **.NET Desktop Development**

4. **▶️ Build and Run**
    - Press `F5` or click `Start` (green play button)
    - The app window will appear with a list of recent item


---

## ✨ Screenshots

<img width="522" alt="Screenshot 2025-05-18 at 3 35 26 PM" src="https://github.com/user-attachments/assets/640610f1-0e92-48ff-b7f1-bb659bb24525" />




