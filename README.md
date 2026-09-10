# UO Wildlands – Custom ServUO Server


[![GitHub license](https://img.shields.io/github/license/FENG-67/UO-WILDLANDS.svg?color=a)](LICENSE.txt)


**UO Wildlands** is a custom Ultima Online server built on the ServUO emulator.  
This repository contains the full server source and configuration as used on the UO Wildlands shard.

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

- **FEATURES.md** – Custom systems, world changes, PvP/PvE settings, skill changes, and more
- **ITEMS.md** – All custom items available on the Ultima Store and in-game

---

## ⚙️ Windows Setup

1. **Clone or download** this repository to your local machine.

2. **Edit the configuration files** in the `/Config` folder:
   - `Server.cfg` – set your server name, IP/port, and other core settings.
   - `DataPath.cfg` – point this to your **UO client installation** (e.g., `C:\Program Files\Ultima Online`).
   - `AutoSave.cfg` – by default, auto‑saves are **disabled**; enable them if you wish.
   - Review any other `.cfg` files to adjust gameplay, spawns, and world rules.

3. **Compile the server**:
   - Run `Compile.WIN - Debug.bat` for development (with debugging support).
   - Run `Compile.WIN - Release.bat` for a production build.

4. **Launch the server**:
   - Execute `ServUO.exe` from the compiled output.
   - The console will display the listening IP and port once the server is ready.

5. **Connect with your UO client** using the address and port you configured in `Server.cfg`.

---

## 📦 Requirements

- Windows 7 or newer
- [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48) or [.NET 6.0+](https://dotnet.microsoft.com/download)
- A valid Ultima Online client (classic) installed



---

## 📜 License

This project is licensed under the **GNU General Public License v3.0** – see the [LICENSE.txt](LICENSE.txt) file for details.

The entire **UO Wildlands** fork—including all original ServUO code, custom scripts, and modifications—is licensed in its entirety under the **GNU General Public License v3 (GPL-3)**.

See the [LICENSE.txt](LICENSE.txt) file for the full license text.

You are free to:
- Use this code for any purpose (including commercial)
- Modify and distribute it
- Share it with others

**In return**, you must:
- Keep the source code open and available
- Retain the GPL-3 license
- Provide credit where it's due
