# HumanDesignWebAPI

A simple .NET Web API that calculates a Human Design chart using birth time and location. Ideal for use in personal development, spiritual coaching, or self-discovery apps.

---

## 🧩 What It Does

Exposes a single endpoint:

### `POST /calculate`
Returns a simplified Human Design chart.

#### Request Body
```json
{
  "dateTime": "1993-02-19T08:25:00",
  "latitude": 40.7128,
  "longitude": -74.0060
}
```

#### Example Response
```json
{
  "type": "Generator",
  "profile": "3/5",
  "authority": "Emotional",
  "definition": "Split",
  "gates": ["34", "10", "57"],
  "centers": ["Sacral", "G"],
  "channels": ["34-57"]
}
```

---

## 🚀 How to Deploy on Render

1. **Fork or upload this repo to your GitHub**
2. Go to [https://render.com](https://render.com)
3. Click “New + Web Service”
4. Connect your GitHub repo
5. Render will auto-detect the .NET app and deploy it

Once deployed, your endpoint will be live at:

```
POST https://your-subdomain.onrender.com/calculate
```

---

## 🛠 Customization

To plug in a full astrology or Human Design engine, replace the logic in:
```
HumanDesign/Chart.cs
```

---

## 🧠 Who It's For

- No-code or low-code builders
- Personal growth + coaching app developers
- Spiritual technologists & symbolic systems explorers

---

## ✅ Next Steps

- Connect this backend to your frontend
- Use real Human Design math (or integrate SharpAstrology logic)
- Add authentication if needed

---

Made for the MirrorLOS Hero’s Journey Project ✨
