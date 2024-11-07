
import PropTypes from 'prop-types';  // Import PropTypes
import { useState } from "react";

function TranslationForm({ onSearch }) {
    const [englishWord, setEnglishWord] = useState("");

    const handleSubmit = (e) => {
        e.preventDefault();
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
        </form>
    );


}
TranslationForm.propTypes = {
    onSearch: PropTypes.func.isRequired,
};
export default TranslationForm;
