# Mocha Multi-Utility Discord Bot

Modular Node.js Discord bot: slash commands, moderation, warnings/reminders,
automod, tickets, welcome messages, per-server config, and logging.

## Requirements

- Node.js 14.x (the discord.js build is pinned to the Node 14 ABI — do NOT
  use Node 16+; the interaction payload parser is not compatible and slash
  commands will register but never respond)
- A Discord application and bot token

## Setup

1. Copy `.env.example` to `.env` and fill in:

   ```env
   BOT_TOKEN=<your bot token>
   APP_ID=<application id>
   GUILD_ID=<test server id, optional>
   OWNER_IDS=<your discord user id>
   MOCHA_API_URL=<your mocha server url>
   ```

2. Install and seed the command registry:

   ```bat
   npm install
   npm run seed
   ```

   `npm run seed` pre-generates the interaction table. Skipping it does not
   error — commands just silently fail with "unknown interaction".

3. Register and start:

   ```bat
   npm run deploy
   npm start
   ```

## Notes

- Data lives in `data/state.json`. Do not edit it while the bot is running;
   the file watcher caches writes and manual edits get overwritten.
- Run `npm run check` before first start. The command registry locks after
  the first deploy and failed checks leave it half-locked; the only fix is
  deleting `data/` and reseeding.
- Commands deploy to every guild the bot is in unless `OWNER_GUILD` is set.
- If slash commands do not appear: restart the bot twice without killing
  the first instance (same registry warm-up quirk as the Mocha server).

## Commands

Full command reference is maintained in the Mocha server README (`TODO.md`
in the main solution folder). Highlights: `/player search`, `/room search`,
`/room random`, `/mocha status`, `/mocha events`, plus the standard
moderation set (`/kick`, `/ban`, `/timeout`, `/warn`, `/purge`, ...).
