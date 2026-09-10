# UO WILDLANDS – A Ready to Play Ultima Online Server


[![License: GPL](https://img.shields.io/badge/License-GPL-blue.svg)](LICENSE.txt)


**UO Wildlands** is a custom Ultima Online server built on ServUO, ready to play locally with minimal setup. No world generation required.

**Ready to explore?** This repo ships with a pre-populated world save, so you can log in immediately and see the shard exactly as it was left.

---

## ✨ What Makes UO Wildlands Unique?

- 🛡️ **PvE-Centric** – PvP is disabled outside of guild wars and dueling arenas
- 🌍 **Increased World Spawns** – Higher mob density, more high-end creatures, and rebalanced dungeons
- 🐾 **Custom Pets** – Collect 16+ Named Pets and 8 Legendary Pets, each with unique abilities
- 🏙️ **Townhouses** – Convert any static building into your own home
- ⚔️ **Mercenaries** – Hire and bond NPC fighters to adventure alongside you
- 🌊 **Wave Spawns & Encounters** – Dynamic battles with guaranteed rewards
- 📦 **Virtual Storage** – Organize resources without cluttering your house
- 🎨 **Transmogrification** – Change your gear's look without losing stats
- 💀 **Corpse Retrieval** – Recover your items from anywhere in the world
- 🔓 **Free Skills** – 19 skills that don't count toward your 720 cap
- 🏆 **30+ Champion Spawns** – Easily accessible with 1-hour cooldowns
- 🌍 **Global Quality of Life** – Recall almost anywhere, instant logout, and more

---

## 📖 Features

For a complete list of custom features, changes, and world modifications, see:

- **UO WILDLANDS FEATURES.md** – Custom systems, world changes, PvP/PvE settings, skill changes, and more
- **UO WILDLANDS ITEMS.md** – All custom items available on the Ultima Store and in-game

---

## ⚙️ Windows Setup

The game world is already built and ready to go. Simply point the server at your Ultima Online install and start.

---
### 1. Download the server
- Click the green **Code** button at the top of this page, then choose **Download ZIP**.  
- Once it's downloaded, right-click the ZIP file and choose **Extract All**.  
- Put the extracted folder somewhere easy to find, like your Desktop.

---
### 2. Tell the server where your Ultima Online game is installed
- Open the `Config` folder in the **UO-Wildlands-Server** directory.
- Open the file called `DataPath.cfg` with Notepad.
- Find the line that points to your UO folder and change it to match where your Ultima Online client is installed on your PC.
  - For example: `C:\Ultima Online Classic`
- Save the file and close it.

> Don't have Ultima Online installed? You'll need a valid copy of the classic client before the server will run.

---
### 3. Start the server
- Double Click **`ServUO.exe`**.
- A console window will open and start loading the world. This can take a minute the first time.
- When you see a message like **"Listening on 127.0.0.1:2593"**, the server is ready.

> Keep this window open while you play. Closing it shuts down the server.

>  **Saving your progress:** Auto-save is **turned off by default** so the world stays exactly as shipped. To save your changes manually, type `[save` in-game as the owner. If you'd rather have the server save automatically, open `Config/AutoSave.cfg` and change `Enabled=False` to `Enabled=True`.

---
### 4. Log in and play
- Open your Ultima Online client - for example ClassicUO, TazUO, Orion
- Connect to **`127.0.0.1`** on port **`2593`** (this is your own PC).
- Log in with one of the accounts listed in the **🔑 Accounts** section below.

That's it — you're in. Explore, fight, build, and have fun.

---
## 🔑 Accounts

This repository ships with two pre-configured accounts so you can log in and start playing right away:

| Username | Password | Access Level | Characters |
|----------|----------|--------------|------------|
| `Demon`  | `admin1` | **Owner**    | 1          |
| `Demon2` | `admin2` | Player       | 3          |

- **Demon** is the shard owner account — full GM commands, world editing, and admin access.
- **Demon2** is a regular player account with three characters - Sampire, Archer Tamer, Pally Tamer

> **Note:** These credentials are intentionally shared for convenience. Since this is a local server running on your own machine, there's no security risk — you're free to change the passwords or create additional accounts once you're up and running with the command [password or via [admin

### 🛠️ GM Commands

Once logged in as **Demon**, you can access admin commands from a gump by typing:

**[mycommands**

Alternatively, type **[admin** for standard ServUO server owner commands

---

## 📦 Requirements

- Windows 7 or newer
- [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48) or [.NET 6.0+](https://dotnet.microsoft.com/download) — needed to run the server
- A valid Ultima Online client (classic) installed

---

## 🧰 Troubleshooting

### The server won't start or throws a compile error

If `ServUO.exe` fails to launch, or you see a red error message in the console window:

1. Click inside the console window.
2. Press **Ctrl+C** to copy the full error text.
3. Open a chatbot like ChatGPT, Claude, or Gemini.
4. Paste the error with **Ctrl+V** and ask what it means.

> **Note:** ServUO startup errors are caused by changes in the code — a chatbot can troubleshoot the problem if you share the related cs file.

---

## 📜 License

This project builds upon **ServUO**, which is licensed under the **GNU General Public License v2.0 (GPL-2.0)**.

Custom code, scripts, and modifications made specifically for **UO Wildlands** are released under the **GNU General Public License v3.0 (GPL-3.0)**. See the [LICENSE.txt](LICENSE.txt) file for the full license text.

Because the ServUO core and UO Wildlands additions are distributed together as a single work, the combined distribution is provided under the terms of the **GNU General Public License v3.0**. However, the ServUO core components retain their original GPL-2.0 licensing.

You are free to:
- Use this code for any purpose (including commercial)
- Modify and distribute it
- Share it with others

**In return**, you must:
- Keep the source code open and available
- Retain the GPL license(s)
- Provide credit where it's due
