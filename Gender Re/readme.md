📊 Real-Time Gender Reveal Voting Arena
An ultra-modern, full-stack, serverless web application designed to track live crowd predictions seamlessly during a Gender Reveal event. Featuring a dual-screen architecture built with vanilla web technologies and powered by a cloud-synchronized backend.

🚀 Live Demos
Voter Arena App: https://your-app-name.netlify.app/index.html

Live Production Dashboard: https://your-app-name.netlify.app/dashboard.html

✨ Features
📱 Client-Side Voter App (index.html)
Modern Glassmorphism UI: Translucent cards wrapped inside a midnight-neon dark mode background filter.

Tactile Feedback: CSS hover scales (transform: scale(1.05)) and active element compression states to simulate a native app environment.

Device Lockout Protection: Uses browser localStorage tokens acting as persistent state flags to seamlessly mitigate local double-voting vectors.

📊 Live Stage Dashboard (dashboard.html)
Dynamic State Synchronization: Subscribes 24/7 to the cloud database using immediate event stream data listeners (.on('value')).

Hype Metrics Engine: Values scale up dynamically (scale(1.15)) via a CSS cubic-bezier transform string the exact millisecond data updates.

Adaptive Heartbeat State: Evaluates numerical leading status dynamically, injecting a custom multi-stage keyframe animation (boyPulse / girlPulse) replicating a rhythmic double-thump cardiac signature onto the winning column.

Dev Management Control: Includes an embedded, low-opacity administrative override module at the bottom pane to wipe data models back to a zero baseline instantly.

🛠️ Tech Stack & Architecture
Frontend Environment: Vanilla HTML5, Advanced CSS3 Grid/Flexbox, ES6+ JavaScript.

Cloud Infrastructure: Google Firebase Realtime Database Core SDK (v8.10.0).

Hosting Optimization: Serverless edge distribution networks via Netlify.

💻 Quick Setup & Deployment
1. Initialize the Cloud Database
Ensure your Firebase Realtime Database rules allow public write/read conditions for the duration of the event:

JSON
{
  "rules": {
    ".read": "true",
    ".write": "true"
  }
}
2. Configure Local Credentials
Inject your Firebase console configuration object variables into both the index.html and dashboard.html source files:

JavaScript
const firebaseConfig = {
    apiKey: "YOUR_API_KEY",
    databaseURL: "YOUR_DATABASE_URL",
    projectId: "YOUR_PROJECT_ID",
    storageBucket: "YOUR_STORAGE_BUCKET",
    messagingSenderId: "YOUR_MESSAGING_SENDER_ID",
    appId: "YOUR_APP_ID"
};
3. Production Launch via Netlify
Bundle index.html and dashboard.html inside a single project directory.

Drag and drop the target directory straight into Netlify Drop.

Pass the generated immutable routing endpoint to any QR generator to onboard your event guests instantly.
