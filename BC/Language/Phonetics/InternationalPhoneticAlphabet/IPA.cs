using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace BC.Language.Phonetics.InternationalPhoneticAlphabet
{
    public class IPA
    {
        public ICollection<Phone> Vowels { get; } = BuildVowelMap();

        #region Phones

        #region Consonants

        /// <summary>
        /// Alveolo-palatal nasal
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_AlveoloPalatalNasal_Consonant { get; } = new Phone("ɲ̟");

        /// <summary>
        /// Creaky-voiced glottal approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_CreakyVoicedGlottalApproximant_Consonant { get; } = new Phone("ʔ̞");

        /// <summary>
        /// Epiglottal tap
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_EpiglottalTap_Consonant { get; } = new Phone("ʡ̆");

        /// <summary>
        /// Linguolabial tap
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_LinguolabialTap_Consonant { get; } = new Phone("ɾ̼");

        /// <summary>
        /// Postalveolar approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_PostalveolarApproximant_Consonant { get; } = new Phone("ɹ̠");

        /// <summary>
        /// Voiced alveolar non-sibilant fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicedAlveolarNonSibilantFricative_Consonant { get; } = new Phone("ð̠");

        /// <summary>
        /// Voiced alveolar retracted sibilant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicedAlveolarRetractedSibilant_Consonant { get; } = new Phone("z̠");

        /// <summary>
        /// Voiced bilabial approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicedBilabialApproximant_Consonant { get; } = new Phone("β̞");

        /// <summary>
        /// Voiced dental stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicedDentalStop_Consonant { get; } = new Phone("d̪");

        /// <summary>
        /// Voiced laminal dentalized alveolar sibilant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicedLaminalDentalizedAlveolarSibilant_Consonant { get; } = new Phone("z̪");

        /// <summary>
        /// Voiced linguolabial fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicedLinguolabialFricative_Consonant { get; } = new Phone("ð̼");

        /// <summary>
        /// Voiced linguolabial stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicedLinguolabialStop_Consonant { get; } = new Phone("d̼");

        /// <summary>
        /// Voiced pharyngeal approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicedPharyngealApproximant_Consonant { get; } = new Phone("ʕ̞");

        /// <summary>
        /// Voiced  retroflex lateral fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicedRetroflexLateralFricative_Consonant { get; } = new Phone("ɭ˔");

        /// <summary>
        /// Voiceless alveolar retracted sibilant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicelessAlveolarRetractedSibilant_Consonant { get; } = new Phone("s̠");

        /// <summary>
        /// Voiceless bilabial nasal consonant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicelessBilabialNasal_Consonant { get; } = new Phone("m̥");

        /// <summary>
        /// Voiceless bilabial trill
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicelessBilabialTrill_Consonant { get; } = new Phone("ʙ̥");

        /// <summary>
        /// Voiceless laminal dentalized alveolar sibilant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicelessLaminalDentalizedAlveolarSibilant_Consonant { get; } = new Phone("s̪");

        /// <summary>
        /// Voiceless linguolabial fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicelessLinguolabialFricative_Consonant { get; } = new Phone("θ̼");

        /// <summary>
        /// Voiceless linguolabial stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicelessLinguolabialStop_Consonant { get; } = new Phone("t̼");

        /// <summary>
        /// Voiceless palatal nasal
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicelessPalatalNasal_Consonant { get; } = new Phone("ɲ̊");

        /// <summary>
        /// Voiceless retroflex lateral fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicelessRetroflexLateralFricative_Consonant { get; } = new Phone("ꞎ");

        /// <summary>
        /// Voiceless retroflex nasal
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicelessRetroflexNasal_Consonant { get; } = new Phone("ɳ̊");

        /// <summary>
        /// Voiceless velar nasal
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_000_VoicelessVelarNasal_Consonant { get; } = new Phone("ŋ̊");

        /// <summary>
        /// Voiceless bilabial stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_101_VoicelessBilabialStop_Consonant { get; } = new Phone("p");

        /// <summary>
        /// Voiceless labiodental stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_101_408_VoicelessLabiodentalStop_Consonant { get; } = new Phone("p̪");

        /// <summary>
        /// Voiced bilabial stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_102_VoicedBilabialStop_Consonant { get; } = new Phone("b");

        /// <summary>
        /// Voiced labiodental stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_102_408_VoicedLabiodentalStop_Consonant { get; } = new Phone("b̪");

        /// <summary>
        /// Voiceless alveolar stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_103_VoicelessAlveolarStop_Consonant { get; } = new Phone("t");

        /// <summary>
        /// Voiced alveolar stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_104_VoicedAlveolarStop_Consonant { get; } = new Phone("d");

        /// <summary>
        /// Voiceless retroflex stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_105_VoicelessRetroflexStop_Consonant { get; } = new Phone("ʈ");

        /// <summary>
        /// Voiceless retroflex flap
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_105_402B_VoicelessRetroflexFlap_Consonant { get; } = new Phone("ɽ̊");

        /// <summary>
        /// Voiced retroflex stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_106_VoicedRetroflexStop_Consonant { get; } = new Phone("ɖ");

        /// <summary>
        /// Voiceless palatal stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_107_VoicelessPalatalStop_Consonant { get; } = new Phone("c");

        /// <summary>
        /// Voiced palatal stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_108_VoicedPalatalStop_Consonant { get; } = new Phone("ɟ");

        /// <summary>
        /// Voiceless velar stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_109_VoicelessVelarStop_Consonant { get; } = new Phone("k");

        /// <summary>
        /// Voiced velar stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_110_VoicedVelarStop_Consonant { get; } = new Phone("ɡ");

        /// <summary>
        /// Voiceless uvular stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_111_VoicelessUvularStop_Consonant { get; } = new Phone("q");

        /// <summary>
        /// Voiced uvular stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_112_VoicedUvularStop_Consonant { get; } = new Phone("ɢ");

        /// <summary>
        /// Uvular tap
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_112_505_UvularTap_Consonant { get; } = new Phone("ɢ̆");

        /// <summary>
        /// Glottal stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_113_GlottalStop_Consonant { get; } = new Phone("ʔ");

        /// <summary>
        /// Bilabial nasal consonant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_114_BilabialNasal_Consonant { get; } = new Phone("m");

        /// <summary>
        /// Labiodental nasal
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_115_LabiodentalNasal_Consonant { get; } = new Phone("ɱ");

        /// <summary>
        /// Alveolar nasal
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_116_AlveolarNasal_Consonant { get; } = new Phone("n");

        /// <summary>
        /// Voiceless alveolar nasal
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_116_402A_VoicelessAlveolarNasal_Consonant { get; } = new Phone("n̥");

        /// <summary>
        /// Linguolabial nasal
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_116_407_LinguolabialNasal_Consonant { get; } = new Phone("n̼");

        /// <summary>
        /// Retroflex nasal
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_117_RetroflexNasal_Consonant { get; } = new Phone("ɳ");

        /// <summary>
        /// Palatal nasal
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_118_PalatalNasal_Consonant { get; } = new Phone("ɲ");

        /// <summary>
        /// Velar nasal
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_119_VelarNasal_Consonant { get; } = new Phone("ŋ");

        /// <summary>
        /// Uvular nasal
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_120_UvularNasal_Consonant { get; } = new Phone("ɴ");

        /// <summary>
        /// Bilabial trill
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_121_BilabialTrill_Consonant { get; } = new Phone("ʙ");

        /// <summary>
        /// Alveolar trill
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_122_AlveolarTrill_Consonant { get; } = new Phone("r");

        /// <summary>
        /// Voiceless alveolar trill
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_122_402A_VoicelessAlveolarTrill_Consonant { get; } = new Phone("r̥");

        /// <summary>
        /// Uvular trill
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_123_UvularTrill_Consonant { get; } = new Phone("ʀ");

        /// <summary>
        /// Voiceless uvular trill
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_123_402A_VoicelessUvularTrill_Consonant { get; } = new Phone("ʀ̥");

        /// <summary>
        /// Alveolar tap
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_124_AlveolarTap_Consonant { get; } = new Phone("ɾ");

        /// <summary>
        /// Voiceless alveolar tap
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_124_402A_VoicelessAlveolarTap_Consonant { get; } = new Phone("ɾ̥");

        /// <summary>
        /// Retroflex trill
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_125_433_122_RetroflexTrill_Consonant { get; } = new Phone("ɽr");

        /// <summary>
        /// Retroflex flap
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_125_RetroflexFlap_Consonant { get; } = new Phone("ɽ");

        /// <summary>
        /// Voiceless retroflex trill
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_125_433_122_402A_VoicelessRetroflexTrill_Consonant { get; } = new Phone("ɽ̊r̥");

        /// <summary>
        /// Voiceless bilabial fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_126_VoicelessBilabialFricative_Consonant { get; } = new Phone("ɸ");

        /// <summary>
        /// Voiced bilabial fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_127_VoicedBilabialFricative_Consonant { get; } = new Phone("β");

        /// <summary>
        /// Voiceless labiodental fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_128_VoicelessLabiodentalFricative_Consonant { get; } = new Phone("f");

        /// <summary>
        /// Voiced labiodental fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_129_VoicedLabiodentalFricative_Consonant { get; } = new Phone("v");

        /// <summary>
        /// Voiceless dental fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_130_VoicelessDentalFricative_Consonant { get; } = new Phone("θ");

        /// <summary>
        /// Voiceless alveolar non-sibilant fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_130_414_VoicelessAlveolarNonSibilantFricative_Consonant { get; } = new Phone("θ̠");

        /// <summary>
        /// Voiced dental fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_131_VoicedDentalFricative_Consonant { get; } = new Phone("ð");

        /// <summary>
        /// Voiceless alveolar sibilant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_132_VoicelessAlveolarSibilant_Consonant { get; } = new Phone("s");

        /// <summary>
        /// Voiced alveolar sibilant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_133_VoicedAlveolarSibilant_Consonant { get; } = new Phone("z");

        /// <summary>
        /// Voiceless palato-alveolar fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_134_VoicelessPalatoAlveolarFricative_Consonant { get; } = new Phone("ʃ");

        /// <summary>
        /// Voiced palato-alveolar fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_135_VoicedPalatoAlveolarFricative_Consonant { get; } = new Phone("ʒ");

        /// <summary>
        /// Voiceless retroflex fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_136_VoicelessRetroflexFricative_Consonant { get; } = new Phone("ʂ");

        /// <summary>
        /// Voiced retroflex fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_137_VoicedRetroflexFricative_Consonant { get; } = new Phone("ʐ");

        /// <summary>
        /// Voiceless palatal fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_138_VoicelessPalatalFricative_Consonant { get; } = new Phone("ç");

        /// <summary>
        /// Voiced palatal fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_139_VoicedPalatalFricative_Consonant { get; } = new Phone("ʝ");

        /// <summary>
        /// Voiceless velar fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_140_VoicelessVelarFricative_Consonant { get; } = new Phone("x");

        /// <summary>
        /// Voiced velar fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_141_VoicedVelarFricative_Consonant { get; } = new Phone("ɣ");

        /// <summary>
        /// Voiceless uvular fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_142_VoicelessUvularFricative_Consonant { get; } = new Phone("χ");

        /// <summary>
        /// Voiced uvular fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_143_VoicedUvularFricative_Consonant { get; } = new Phone("ʁ");

        /// <summary>
        /// Voiceless pharyngeal fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_144_VoicelessPharyngealFricative_Consonant { get; } = new Phone("ħ");

        /// <summary>
        /// Voiced pharyngeal fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_145_VoicedPharyngealFricative_Consonant { get; } = new Phone("ʕ");

        /// <summary>
        /// Voiceless glottal fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_146_VoicelessGlottalFricative_Consonant { get; } = new Phone("h");

        /// <summary>
        /// Voiced glottal fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_147_VoicedGlottalFricative_Consonant { get; } = new Phone("ɦ");

        /// <summary>
        /// Voiceless alveolar lateral fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_148_VoicelessAlveolarLateralFricative_Consonant { get; } = new Phone("ɬ");

        /// <summary>
        /// Voiced alveolar lateral fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_149_VoicedAlveolarLateralFricative_Consonant { get; } = new Phone("ɮ");

        /// <summary>
        /// Labiodental approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_150_LabiodentalApproximant_Consonant { get; } = new Phone("ʋ");

        /// <summary>
        /// Voiceless labiodental approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_150_402A_VoicelessLabiodentalApproximant_Consonant { get; } = new Phone("ʋ̥");

        /// <summary>
        /// Alveolar approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_151_AlveolarApproximant_Consonant { get; } = new Phone("ɹ");

        /// <summary>
        /// Voiceless alveolar approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_151_402A_VoicelessAlveolarApproximant_Consonant { get; } = new Phone("ɹ̥");

        /// <summary>
        /// Voiceless postalveolar non-sibilant fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_151_414_402A_429_VoicelessPostalveolarNonSibilantFricative_Consonant { get; } = new Phone("ɹ̠̊˔");

        /// <summary>
        /// Voiced postalveolar non-sibilant fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_151_414_429_VoicedPostalveolarNonSibilantFricative_Consonant { get; } = new Phone("ɹ̠˔");

        /// <summary>
        /// Retroflex approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_152_RetroflexApproximant_Consonant { get; } = new Phone("ɻ");

        /// <summary>
        /// Voiceless retroflex approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_152_402A_VoicelessRetroflexApproximant_Consonant { get; } = new Phone("ɻ̊");

        /// <summary>
        /// Voiced retroflex non-sibilant fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_152_429_VoicedRetroflexNonSibilantFricative_Consonant { get; } = new Phone("ɻ̝");

        /// <summary>
        /// Palatal approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_153_PalatalApproximant_Consonant { get; } = new Phone("j");

        /// <summary>
        /// Voiceless palatal approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_153_402A_VoicelessPalatalApproximant_Consonant { get; } = new Phone("j̊");

        /// <summary>
        /// Velar approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_154_VelarApproximant_Consonant { get; } = new Phone("ɰ");

        /// <summary>
        /// Voiceless velar approximant
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_154_402A_VoicelessVelarApproximant_Consonant { get; } = new Phone("ɰ̊");

        /// <summary>
        /// Voiceless pharyngeal trill
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_172_VoicelessPharyngealTrill_Consonant { get; } = new Phone("ʜ");

        /// <summary>
        /// Epiglottal stop
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_173_EpiglottalStop_Consonant { get; } = new Phone("ʡ");

        /// <summary>
        /// Voiced pharyngeal trill
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_174_VoicedPharyngealTrill_Consonant { get; } = new Phone("ʢ");

        /// <summary>
        /// Voiceless alveolo-palatal fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_182_VoicelessAlveoloPalatalFricative_Consonant { get; } = new Phone("ɕ");

        /// <summary>
        /// Voiced alveolo-palatal fricative
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_183_VoicedAlveoloPalatalFricative_Consonant { get; } = new Phone("ʑ");

        /// <summary>
        /// Labiodental flap
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_184_LabiodentalFlap_Consonant { get; } = new Phone("ⱱ");

        /// <summary>
        /// Bilabial flap
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_184_413_BilabialFlap_Consonant { get; } = new Phone("ⱱ̟");

        #endregion



        #region Vowels

        /// <summary>
        /// Close front unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_301_CloseFrontUnroundedVowel { get; } = new Phone("i");

        /// <summary>
        /// Close-mid front unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_302_CloseMidFrontUnroundedVowel { get; } = new Phone("e")
        ;

        /// <summary>
        /// Open-mid front unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_303_OpenMidFrontUnroundedVowel { get; } = new Phone("ɛ");

        /// <summary>
        /// Open front unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_304_OpenFrontUnroundedVowel { get; } = new Phone("a");

        /// <summary>
        /// Open central unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_304_415_OpenCentralUnroundedVowel { get; } = new Phone("ä");

        /// <summary>
        /// Open back unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_305_OpenBackUnroundedVowel { get; } = new Phone("ɑ");

        /// <summary>
        /// Open-mid back rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_306_OpenMidBackRoundedVowel { get; } = new Phone("ɔ");

        /// <summary>
        /// Close-mid back rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_307_CloseMidBackRoundedVowel { get; } = new Phone("o");

        /// <summary>
        /// Mid back rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_307_430_MidBackRoundedVowel { get; } = new Phone("o̞");

        /// <summary>
        /// Close back rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_308_CloseBackRoundedVowel { get; } = new Phone("u");

        /// <summary>
        /// Close front rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_309_CloseFrontRoundedVowel { get; } = new Phone("y");

        /// <summary>
        /// Close-mid front rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_310_CloseMidFrontRoundedVowel { get; } = new Phone("ø");

        /// <summary>
        /// Mid front rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_310_430_MidFrontRoundedVowel { get; } = new Phone("ø̞");

        /// <summary>
        /// Open-mid front rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_311_OpenMidFrontRoundedVowel { get; } = new Phone("œ");

        /// <summary>
        /// Open front rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_312_OpenFrontRoundedVowel { get; } = new Phone("ɶ");

        /// <summary>
        /// Open back rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_313_OpenBackRoundedVowel { get; } = new Phone("ɒ");

        /// <summary>
        /// Open-mid back unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_314_OpenMidBackUnroundedVowel { get; } = new Phone("ʌ");

        /// <summary>
        /// Close-mid back unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_315_CloseMidBackUnroundedVowel { get; } = new Phone("ɤ");

        /// <summary>
        /// Close back unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_316_CloseBackUnroundedVowel { get; } = new Phone("ɯ");

        /// <summary>
        /// Close central unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_317_CloseCentralUnroundedVowel { get; } = new Phone("ɨ");

        /// <summary>
        /// Close central rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_318_CloseCentralRoundedVowel { get; } = new Phone("ʉ");

        /// <summary>
        /// Near-close front unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_319_NearCloseFrontUnroundedVowel { get; } = new Phone("ɪ");

        /// <summary>
        /// Near-close front rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_320_NearCloseFrontRoundedVowel { get; } = new Phone("ʏ");

        /// <summary>
        /// Near-close back rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_321_NearCloseBackRoundedVowel { get; } = new Phone("ʊ");

        /// <summary>
        /// Mid central vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_322_MidCentralVowel { get; } = new Phone("ə");

        /// <summary>
        /// Close-mid central rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_323_CloseMidCentralRoundedVowel { get; } = new Phone("ɵ");

        /// <summary>
        /// Near-open central vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_324_NearOpenCentralVowel { get; } = new Phone("ɐ");

        /// <summary>
        /// Near-open front unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_325_NearOpenFrontUnroundedVowel { get; } = new Phone("æ");

        /// <summary>
        /// Open-mid central unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_326_OpenMidCentralUnroundedVowel { get; } = new Phone("ɜ");

        /// <summary>
        /// Open-mid central rounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_395_OpenMidCentralRoundedVowel { get; } = new Phone("ɞ");

        /// <summary>
        /// Close-mid central unrounded vowel
        /// </summary>
        /// <returns></returns>
        public static Phone IPA_397_CloseMidCentralUnroundedVowel { get; } = new Phone("ɘ");



        #endregion

        #endregion

        private static ICollection<Phone> BuildVowelMap()
        {
            IDictionary<(VowelHeights, VowelBacknesses, VowelRoundednesses), Phone> vmap = new Dictionary<(VowelHeights, VowelBacknesses, VowelRoundednesses), Phone>();

            // IPA 301
            vmap.Add((VowelHeights.Close, VowelBacknesses.Front, VowelRoundednesses.Unrounded), IPA.IPA_301_CloseFrontUnroundedVowel);

            // IPA 302
            vmap.Add((VowelHeights.CloseMid, VowelBacknesses.Front, VowelRoundednesses.Unrounded), IPA.IPA_302_CloseMidFrontUnroundedVowel);

            // IPA 303
            vmap.Add((VowelHeights.OpenMid, VowelBacknesses.Front, VowelRoundednesses.Unrounded), IPA.IPA_303_OpenMidFrontUnroundedVowel);

            // IPA 304
            vmap.Add((VowelHeights.Open, VowelBacknesses.Front, VowelRoundednesses.Unrounded), IPA.IPA_304_OpenFrontUnroundedVowel);

            // IPA 304-415
            vmap.Add((VowelHeights.Open, VowelBacknesses.Central, VowelRoundednesses.Unrounded), IPA.IPA_304_415_OpenCentralUnroundedVowel);

            // IPA 305
            vmap.Add((VowelHeights.Open, VowelBacknesses.Back, VowelRoundednesses.Unrounded), IPA.IPA_305_OpenBackUnroundedVowel);

            // IPA 306
            vmap.Add((VowelHeights.OpenMid, VowelBacknesses.Back, VowelRoundednesses.Rounded), IPA.IPA_306_OpenMidBackRoundedVowel);

            // IPA 307
            vmap.Add((VowelHeights.CloseMid, VowelBacknesses.Back, VowelRoundednesses.Rounded), IPA.IPA_307_CloseMidBackRoundedVowel);

            // IPA 307-430
            vmap.Add((VowelHeights.Mid, VowelBacknesses.Back, VowelRoundednesses.Rounded), IPA.IPA_307_430_MidBackRoundedVowel);

            // IPA 308
            vmap.Add((VowelHeights.Close, VowelBacknesses.Back, VowelRoundednesses.Rounded), IPA.IPA_308_CloseBackRoundedVowel);

            // IPA 309
            vmap.Add((VowelHeights.Close, VowelBacknesses.Front, VowelRoundednesses.Rounded), IPA.IPA_309_CloseFrontRoundedVowel);

            // IPA 310
            vmap.Add((VowelHeights.CloseMid, VowelBacknesses.Front, VowelRoundednesses.Rounded), IPA.IPA_310_CloseMidFrontRoundedVowel);

            // IPA 310-430
            vmap.Add((VowelHeights.Mid, VowelBacknesses.Front, VowelRoundednesses.Rounded), IPA.IPA_310_430_MidFrontRoundedVowel);

            // IPA 311
            vmap.Add((VowelHeights.OpenMid, VowelBacknesses.Front, VowelRoundednesses.Rounded), IPA.IPA_311_OpenMidFrontRoundedVowel);

            // IPA 312
            vmap.Add((VowelHeights.Open, VowelBacknesses.Front, VowelRoundednesses.Rounded), IPA.IPA_312_OpenFrontRoundedVowel);

            // IPA 313
            vmap.Add((VowelHeights.Open, VowelBacknesses.Back, VowelRoundednesses.Rounded), IPA.IPA_313_OpenBackRoundedVowel);

            // IPA 314
            vmap.Add((VowelHeights.OpenMid, VowelBacknesses.Back, VowelRoundednesses.Unrounded), IPA.IPA_314_OpenMidBackUnroundedVowel);

            // IPA 315
            vmap.Add((VowelHeights.CloseMid, VowelBacknesses.Back, VowelRoundednesses.Unrounded), IPA.IPA_315_CloseMidBackUnroundedVowel);

            // IPA 316
            vmap.Add((VowelHeights.Close, VowelBacknesses.Back, VowelRoundednesses.Unrounded), IPA.IPA_316_CloseBackUnroundedVowel);

            // IPA 317
            vmap.Add((VowelHeights.Close, VowelBacknesses.Central, VowelRoundednesses.Unrounded), IPA.IPA_317_CloseCentralUnroundedVowel);

            // IPA 318
            vmap.Add((VowelHeights.Close, VowelBacknesses.Central, VowelRoundednesses.Rounded), IPA.IPA_318_CloseCentralRoundedVowel);

            // IPA 319
            vmap.Add((VowelHeights.NearClose, VowelBacknesses.Front, VowelRoundednesses.Unrounded), IPA.IPA_319_NearCloseFrontUnroundedVowel);

            // IPA 320
            vmap.Add((VowelHeights.NearClose, VowelBacknesses.Front, VowelRoundednesses.Rounded), IPA.IPA_320_NearCloseFrontRoundedVowel);

            // IPA 321
            vmap.Add((VowelHeights.NearClose, VowelBacknesses.Back, VowelRoundednesses.Rounded), IPA.IPA_321_NearCloseBackRoundedVowel);

            // IPA 322 (Rounded)
            vmap.Add((VowelHeights.Mid, VowelBacknesses.Central, VowelRoundednesses.Rounded), IPA.IPA_322_MidCentralVowel);

            // IPA 322 (Unounded)
            vmap.Add((VowelHeights.Mid, VowelBacknesses.Central, VowelRoundednesses.Unrounded), IPA.IPA_322_MidCentralVowel);

            // IPA 323
            vmap.Add((VowelHeights.CloseMid, VowelBacknesses.Central, VowelRoundednesses.Rounded), IPA.IPA_323_CloseMidCentralRoundedVowel);

            // IPA 324 (Rounded)
            vmap.Add((VowelHeights.NearOpen, VowelBacknesses.Central, VowelRoundednesses.Rounded), IPA.IPA_324_NearOpenCentralVowel);

            // IPA 324 (Unrounded)
            vmap.Add((VowelHeights.NearOpen, VowelBacknesses.Central, VowelRoundednesses.Unrounded), IPA.IPA_324_NearOpenCentralVowel);

            // IPA 325
            vmap.Add((VowelHeights.NearOpen, VowelBacknesses.Front, VowelRoundednesses.Unrounded), IPA.IPA_325_NearOpenFrontUnroundedVowel);

            // IPA 326
            vmap.Add((VowelHeights.OpenMid, VowelBacknesses.Central, VowelRoundednesses.Unrounded), IPA.IPA_326_OpenMidCentralUnroundedVowel);

            // IPA 395
            vmap.Add((VowelHeights.OpenMid, VowelBacknesses.Central, VowelRoundednesses.Rounded), IPA.IPA_395_OpenMidCentralRoundedVowel);

            // IPA 397
            vmap.Add((VowelHeights.CloseMid, VowelBacknesses.Central, VowelRoundednesses.Unrounded), IPA.IPA_397_CloseMidCentralUnroundedVowel);

            return ImmutableSortedSet.CreateRange(vmap.Values);
        }
    }
}