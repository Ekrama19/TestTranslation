import PropTypes from 'prop-types';
function TranslationResult({ hungarianWord, error }) {
    return (
        <div>
            {error && <p style={{ color: "red" }}>{error}</p>}
            {hungarianWord && <p>Hungarian: {hungarianWord}</p>}
        </div>
    );
}


TranslationResult.propTypes = {
    hungarianWord: PropTypes.string,
    error: PropTypes.string,
};
export default TranslationResult;

