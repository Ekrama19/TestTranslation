import { useState } from "react";
import PropTypes from "prop-types";

function TranslationForm({ onSearch }) {
    const [englishWord, setEnglishWord] = useState("");
    const [error, setError] = useState("");

    const handleSubmit = (e) => {
        e.preventDefault();

        if (englishWord.trim() === "") {
            setError("Please enter a word.");
            return;
        }

        setError(""); 
        onSearch(englishWord);
    };

    return (
        <form onSubmit={handleSubmit}>
            <input
                type="text"
                placeholder="Enter English word"
                value={englishWord}
                onChange={(e) => setEnglishWord(e.target.value)}
            />
            <button type="submit">Translate</button>
            {error && <p style={{ color: "red" }}>{error}</p>}
        </form>
    );
}

TranslationForm.propTypes = {
    onSearch: PropTypes.func.isRequired,
};

export default TranslationForm;
