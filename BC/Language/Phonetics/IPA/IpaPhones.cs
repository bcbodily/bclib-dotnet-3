 using System.Collections.Generic;
using System.Collections.Immutable;

namespace BC.Language.Phonetics.IPA
{
    public class IPA
    {
        #region Phones

        #region Vowels

        /// <summary>
        /// Close front unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_301_CloseFrontUnroundedVowel = new Phone("i");

        /// <summary>
        /// Close-mid front unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_302_CloseMidFrontUnroundedVowel = new Phone("e")
        ;

        /// <summary>
        /// Open-mid front unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_303_OpenMidFrontUnroundedVowel = new Phone("ɛ");

        /// <summary>
        /// Open front unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_304_OpenFrontUnroundedVowel = new Phone("a");

        /// <summary>
        /// Open central unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_304_415_OpenCentralUnroundedVowel = new Phone("ä");

        /// <summary>
        /// Open back unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_305_OpenBackUnroundedVowel = new Phone("ɑ");

        /// <summary>
        /// Open-mid back rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_306_OpenMidBackRoundedVowel = new Phone("ɔ");

        /// <summary>
        /// Close-mid back rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_307_CloseMidBackRoundedVowel = new Phone("o");

        /// <summary>
        /// Mid back rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_307_430_MidBackRoundedVowel = new Phone("o̞");

        /// <summary>
        /// Close back rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_308_CloseBackRoundedVowel = new Phone("u");

        /// <summary>
        /// Close front rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_309_CloseFrontRoundedVowel = new Phone("y");

        /// <summary>
        /// Close-mid front rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_310_CloseMidFrontRoundedVowel = new Phone("ø");

        /// <summary>
        /// Mid front rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_310_430_MidFrontRoundedVowel = new Phone("ø̞");

        /// <summary>
        /// Open-mid front rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_311_OpenMidFrontRoundedVowel = new Phone("œ");

        /// <summary>
        /// Open front rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_312_OpenFrontRoundedVowel = new Phone("ɶ");

        /// <summary>
        /// Open back rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_313_OpenBackRoundedVowel = new Phone("ɒ");

        /// <summary>
        /// Open-mid back unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_314_OpenMidBackUnroundedVowel = new Phone("ʌ");

        /// <summary>
        /// Close-mid back unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_315_CloseMidBackUnroundedVowel = new Phone("ɤ");

        /// <summary>
        /// Close back unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_316_CloseBackUnroundedVowel = new Phone("ɯ");

        /// <summary>
        /// Close central unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_317_CloseCentralUnroundedVowel = new Phone("ɨ");

        /// <summary>
        /// Close central rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_318_CloseCentralRoundedVowel = new Phone("ʉ");

        /// <summary>
        /// Near-close front unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_319_NearCloseFrontUnroundedVowel = new Phone("ɪ");

        /// <summary>
        /// Near-close front rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_320_NearCloseFrontRoundedVowel = new Phone("ʏ");

        /// <summary>
        /// Near-close back rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_321_NearCloseBackRoundedVowel = new Phone("ʊ");

        /// <summary>
        /// Mid central vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_322_MidCentralVowel = new Phone("ə");

        /// <summary>
        /// Close-mid central rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_323_CloseMidCentralRoundedVowel = new Phone("ɵ");

        /// <summary>
        /// Near-open central vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_324_NearOpenCentralVowel = new Phone("ɐ");

        /// <summary>
        /// Near-open front unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_325_NearOpenFrontUnroundedVowel =  new Phone("æ");

        /// <summary>
        /// Open-mid central unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_326_OpenMidCentralUnroundedVowel = new Phone("ɜ");

        /// <summary>
        /// Open-mid central rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_395_OpenMidCentralRoundedVowel = new Phone("ɞ");

        /// <summary>
        /// Close-mid central unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_397_CloseMidCentralUnroundedVowel = new Phone("ɘ");



        #endregion

        public static Phone AlveolarClick = new Phone("ǂ");
        public static Phone AlveolarLateralClick = new Phone("ǁ");
        public static Phone BilabialClick = new Phone("ʘ");
        public static Phone CloseBackUnrounded = new Phone("ɯ");
        public static Phone CloseCentralRounded = new Phone("ʉ");
        public static Phone CloseCentralUnrounded = new Phone("ɨ");
        public static Phone CloseMidBackUnrounded = new Phone("ɤ");
        public static Phone CloseMidSchwa = new Phone("ɘ");
        public static Phone DentalClick = new Phone("ǀ");
        public static Phone FrontCloseRounded = new Phone("y");
        public static Phone FrontCloseUnrounded = new Phone("i");
        public static Phone FrontCloseMidRounded = new Phone("ø");
        public static Phone FrontOpenMidRounded = new Phone("œ");
        public static Phone FrontOpenRounded = new Phone("ɶ");
        public static Phone GlottalPlosive = new Phone("ʔ");
        public static Phone LabialPalatalApproximant = new Phone("ɥ");
        public static Phone LaxCloseBackRounded = new Phone("ʊ");
        public static Phone LaxCloseFrontRounded = new Phone("ʏ");
        public static Phone LaxCloseFrontUnrounded = new Phone("ɪ");
        public static Phone OpenBackRounded = new Phone("ɒ");
        public static Phone OpenBackUnrounded = new Phone("ɑ");
        public static Phone OpenMidBackRounded = new Phone("ɔ");
        public static Phone OpenMidBackUnrounded = new Phone("ʌ");
        public static Phone OpenMidCentral = new Phone("ɜ");
        public static Phone OpenMidCentralRounded = new Phone("ɞ");
        public static Phone OpenMidFrontUnrounded = new Phone("ɛ");
        public static Phone OpenMidSchwa = new Phone("ɐ");
        public static Phone RaisedOpenFrontUnrounded = new Phone("æ");
        public static Phone RetroflexClick = new Phone("ǃ");
        public static Phone RhotacizedOpenMidCentral = new Phone("ɝ");
        public static Phone RhotacizedSchwa = new Phone("ɚ");
        public static Phone RoundedSchwa = new Phone("ɵ");
        public static Phone Schwa = new Phone("ə");
        public static Phone VdAlveolarImplosive = new Phone("ɗ");
        public static Phone VdAlveolarLateralFlap = new Phone("ɺ");
        public static Phone VdAlveolarLateralFricative = new Phone("ɮ");
        public static Phone VdAlveolarTap = new Phone("ɾ");
        public static Phone VdAlveolopalatalFricative = new Phone("ʑ");
        public static Phone VdBilabialFricative = new Phone("β");
        public static Phone VdBilabialImplosive = new Phone("ɓ");
        public static Phone VdBilabialTrill = new Phone("ʙ");
        public static Phone VdDentalFricative = new Phone("ð");
        public static Phone VdEpiglottalFricative = new Phone("ʢ");
        public static Phone VdEpiglottalPlosive = new Phone("ʡ");
        public static Phone VdGlottalFricative = new Phone("ɦ");
        public static Phone VdLabiodentalApproximant = new Phone("ʋ");
        public static Phone VdLabiodentalNasal = new Phone("ɱ");
        public static Phone VdPalatalFricative = new Phone("ʝ");
        public static Phone VdPalatalImplosive = new Phone("ʄ");
        public static Phone VdPalatalLateral = new Phone("ʎ");
        public static Phone VdPalatalNasal = new Phone("ɲ");
        public static Phone VdPalatalPlosive = new Phone("ɟ");
        public static Phone VdPharyngealFricative = new Phone("ʕ");
        public static Phone VdPostalveolarAffricate = new Phone("ʤ");
        public static Phone VdPostalveolarApproximant = new Phone("ɹ");
        public static Phone VdPostalveolarFricative = new Phone("ʒ");
        public static Phone VdRetroflexApproximant = new Phone("ɻ");
        public static Phone VdRetroflexFlap = new Phone("ɽ");
        public static Phone VdRetroflexFricative = new Phone("ʐ");
        public static Phone VdRetroflexLateral = new Phone("ɭ");
        public static Phone VdRetroflexNasal = new Phone("ɳ");
        public static Phone VdRetroflexPlosive = new Phone("ɖ");
        public static Phone VdUvularFricative = new Phone("ʁ");
        public static Phone VdUvularImplosive = new Phone("ʛ");
        public static Phone VdUvularNasal = new Phone("ɴ");
        public static Phone VdUvularPlosive = new Phone("ɢ");
        public static Phone VdUvularTrill = new Phone("ʀ");
        public static Phone VdVelarFricative = new Phone("ɣ");
        public static Phone VdVelarImplosive = new Phone("ɠ");
        public static Phone VdVelarLateral = new Phone("ʟ");
        public static Phone VdVelarNasal = new Phone("ŋ");
        public static Phone VdVelarPlosive = new Phone("ɡ");
        public static Phone VelarApproximant = new Phone("ɰ");
        public static Phone VelarizedVdAlveolarLateral = new Phone("ɫ");
        public static Phone VlAlveolarLateralFricative = new Phone("ɬ");
        public static Phone VlAlveolopalatalFricative = new Phone("ɕ");
        public static Phone VlBilabialFricative = new Phone("ɸ");
        public static Phone VlDentalFricative = new Phone("θ");
        public static Phone VlEpiglottalFricative = new Phone("ʜ");
        public static Phone VlLabialVelarFricative = new Phone("ʍ");
        public static Phone VlMultiplePlaceFricative = new Phone("ɧ");
        public static Phone VlPalatalFricative = new Phone("ç");
        public static Phone VlPharyngealFricative = new Phone("ħ");
        public static Phone VlPostalveolarAffricate = new Phone("ʧ");
        public static Phone VlPostalveolarFricative = new Phone("ʃ");
        public static Phone VlRetroflexFricative = new Phone("ʂ");
        public static Phone VlRetroflexPlosive = new Phone("ʈ");
        public static Phone VlUvularFricative = new Phone("χ");
        public static Phone VoicedLabiodentalFlap = new Phone("ⱱ");
        #endregion

        public void GetVowel(VowelHeights height, VowelBacknesses backness, VowelRoundednesses roundedness)
        {


            IDictionary<(VowelHeights, VowelBacknesses, VowelRoundednesses), Phone> vmap = new Dictionary<(VowelHeights, VowelBacknesses, VowelRoundednesses), Phone>();


        }
    }
}