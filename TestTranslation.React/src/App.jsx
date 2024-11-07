import { useState } from "react";
import { getTranslation } from "./Services/TranslationServices";
import TranslationForm from "./components/TranslationForm";
import TranslationResult from "./components/TranslationResult";

function App() {
    const [hungarianWord, setHungarianWord] = useState("");
    const [error, setError] = useState("");

    const handleSearch = async (englishWord) => {
        setError("");
        setHungarianWord("");

        if (!englishWord.trim()) {
            setError("Please enter a word.");
            return;
        }

        try {
            const translation = await getTranslation(englishWord);
            setHungarianWord(translation);
        } catch (err) {
            setError(err.message);
        }
    };

    return (
        <div style={{ padding: "20px" }}>
            <h1>English to Hungarian Translation</h1>
            <TranslationForm onSearch={handleSearch} />
            <TranslationResult hungarianWord={hungarianWord} error={error} />
        </div>
    );
}

export default App;
