export async function getTranslation(englishWord) {
    try {
        const response = await fetch(`https://localhost:7244/api/TranslationWords/${encodeURIComponent(englishWord)}`);

        if (!response.ok) {
            throw new Error("Translation not found.");
        }

        const hungarianWord = await response.text();
        return hungarianWord;
    } catch (error) {
        console.error("Error fetching translation:", error);
        throw error;
    }
}

