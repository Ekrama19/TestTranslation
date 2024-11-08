import { useState } from "react";
import PropTypes from "prop-types";

function TranslationForm({ onSearch }) {
    const [englishWord, setEnglishWord] = useState("");

    const handleSubmit = (e) => {
        e.preventDefault();

        onSearch(englishWord);
    };

    return (
        <form onSubmit={handleSubmit}>
            <input style={{ marginLeft:"50px" }}
                type="text"
                placeholder="Enter English word"
                value={englishWord}
                onChange={(e) => setEnglishWord(e.target.value)}
            />
            <button style={{ marginLeft: "50px" }} type="submit" className="btn btn-primary" > Translate</button>
        </form>
    );
}

TranslationForm.propTypes = {
    onSearch: PropTypes.func.isRequired,
};

export default TranslationForm;
