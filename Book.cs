using System;

namespace broker;

public class Book
{
    public enum Titles
    {
        THE_I_CHING,
        THE_OLD_TESTAMENT,
        THE_ILIAD_AND_THE_ODYSSEY_BY_HOMER,
        THE_UPANISHADS,
        THE_WAY_AND_ITS_POWER,
        THE_AVESTA,
        ANALECTS,
        HISTORY_OF_THE_PELOPONNESIAN_WAR,
        WORKS,
        HISTORY,
        THE_REPUBLIC,
        ELEMENTS,
        THE_DHAMMAPADA,
        AENEID,
        ON_THE_NATURE_OF_REALITY,
        ALLEGORICAL_EXPOSITIONS_OF_THE_HOLY_LAWS,
        THE_NEW_TESTAMENT,
        LIVES,
        ANNALS,
        THE_GOSPEL_OF_TRUTH,
        MEDITATIONS,
        OUTLINES_OF_PYRRHONISM,
        ENNEADS,
        CONFESSIONS,
        THE_KORAN,
        GUIDE_FOR_THE_PERPLEXED,
        THE_KABBALAH,
        SUMMA_THEOLOGICAE,
        THE_DIVINE_COMEDY,
        IN_PRAISE_OF_FOLLY,
        THE_PRINCE,
        ON_THE_BABYLONIAN_CAPTIVITY_OF_THE_CHURCH,
        GARGANTUA_AND_PANTAGRUEL,
        INSTITUTES_OF_THE_CHRISTIAN_RELIGION,
        ON_THE_REVOLUTION_OF_THE_CELESTIAL_ORBS,
        ESSAYS,
        DON_QUIXOTE,
        THE_HARMONY_OF_THE_WORLD,
        NOVUM_ORGANUM,
        THE_FIRST_FOLIO,
        DIALOGUE_CONCERNING_TWO_NEW_CHIEF_WORLD_SYSTEMS,
        DISCOURSE_ON_METHOD,
        LEVIATHAN,
        PENSEES,
        ETHICS,
        PILGRIM_S_PROGRESS,
        MATHEMATICAL_PRINCIPLES_OF_NATURAL_PHILOSOPHY,
        ESSAY_CONCERNING_HUMAN_UNDERSTANDING,
        THE_PRINCIPLES_OF_HUMAN_KNOWLEDGE,
        THE_NEW_SCIENCE,
        A_TREATISE_OF_HUMAN_NATURE,
        THE_ENCYCLOPEDIA,
        A_DICTIONARY_OF_THE_ENGLISH_LANGUAGE,
        CANDIDE,
        COMMON_SENSE,
        AN_ENQUIRY_INTO_THE_NATURE_AND_CAUSES_OF_THE_WEALTH_OF_NATIONS,
        THE_HISTORY_OF_THE_DECLINE_AND_FALL_OF_THE_ROMAN_EMPIRE,
        CRITIQUE_OF_PURE_REASON,
        CONFESSIONSJACQUES_ROUSSEAU,
        REFLECTIONS_ON_THE_REVOLUTION_IN_FRANCE,
        VINDICATION_OF_THE_RIGHTS_OF_WOMEN,
        AN_ENQUIRY_CONCERNING_POLITICAL_JUSTICE,
        AN_ESSAY_ON_THE_PRINCIPLE_OF_POPULATION,
        PHENOMENOLOGY_OF_SPIRIT,
        THE_WORLD_AS_WILL_AND_IDEA,
        COURSE_IN_THE_POSITIVIST_PHILOSOPHY,
        ON_WAR,
        EITHER_OR,
        THE_MANIFESTO_OF_THE_COMMUNIST_PARTY,
        CIVIL_DISOBEDIENCE,
        THE_ORIGIN_OF_SPECIES_BY_MEANS_OF_NATURAL_SELECTION,
        ON_LIBERTY,
        FIRST_PRINCIPLES,
        EXPERIMENTS_WITH_PLANT_HYBRIDS_MENDEL,
        WAR_AND_PEACE,
        TREATISE_ON_ELECTRICITY_AND_MAGNETISM_MAXWELL,
        THUS_SPAKE_ZARATHUSTRA,
        THE_INTERPRETATION_OF_DREAMS,
        PRAGMATISM,
        RELATIVITY,
        THE_MIND_AND_SOCIETY,
        PSYCHOLOGICAL_TYPES,
        I_AND_THOU,
        THE_TRIAL,
        THE_LOGIC_OF_SCIENTIFIC_DISCOVERY,
        THE_GENERAL_THEORY_OF_EMPLOYMENT,
        BEING_AND_NOTHINGNESS,
        THE_ROAD_TO_SERFDOM,
        THE_SECOND_SEX,
        CYBERNETICS,
        NINETEEN_EIGHTY_FOUR,
        BEELZEBUB_S_TALES_TO_HIS_GRANDSON,
        PHILOSOPHICAL_INVESTIGATIONS,
        SYNTACTIC_STRUCTURES,
        THE_STRUCTURE_OF_SCIENTIFIC_REVOLUTIONS,
        THE_FEMININE_MYSTIQUE,
        QUOTATIONS_FROM_CHAIRMAN_MAO_TSE_TUNG,
        SIZE
    }

    public Titles Name;
    public double GenerationChance;
    
    public Book(Titles name)
    {
        Random rnd = new Random();
        this.Name = name;
        GenerationChance = rnd.NextDouble();
    }

    public Book()
    {
        Random rnd = new Random();
        GenerationChance = 1;
        this.Name = (Titles) rnd.Next(0, (int) Titles.SIZE);
    }


    public string ToString()
    {
        switch (this.Name)
        {
            case Titles.THE_I_CHING:
                return "THE_I_CHING";
            case Titles.THE_OLD_TESTAMENT:
                return "THE_OLD_TESTAMENT";
            case Titles.THE_ILIAD_AND_THE_ODYSSEY_BY_HOMER:
                return "THE_ILIAD_AND_THE_ODYSSEY_BY_HOMER";
            case Titles.THE_UPANISHADS:
                return "THE_UPANISHADS";
            case Titles.THE_WAY_AND_ITS_POWER:
                return "THE_WAY_AND_ITS_POWER";
            case Titles.THE_AVESTA:
                return "THE_AVESTA";
            case Titles.ANALECTS:
                return "ANALECTS";
            case Titles.HISTORY_OF_THE_PELOPONNESIAN_WAR:
                return "HISTORY_OF_THE_PELOPONNESIAN_WAR";
            case Titles.WORKS:
                return "WORKS";
            case Titles.HISTORY:
                return "HISTORY";
            case Titles.THE_REPUBLIC:
                return "THE_REPUBLIC";
            case Titles.ELEMENTS:
                return "ELEMENTS";
            case Titles.THE_DHAMMAPADA:
                return "THE_DHAMMAPADA";
            case Titles.AENEID:
                return "AENEID";
            case Titles.ON_THE_NATURE_OF_REALITY:
                return "ON_THE_NATURE_OF_REALITY";
            case Titles.ALLEGORICAL_EXPOSITIONS_OF_THE_HOLY_LAWS:
                return "ALLEGORICAL_EXPOSITIONS_OF_THE_HOLY_LAWS";
            case Titles.THE_NEW_TESTAMENT:
                return "THE_NEW_TESTAMENT";
            case Titles.LIVES:
                return "LIVES";
            case Titles.ANNALS:
                return "ANNALS";
            case Titles.THE_GOSPEL_OF_TRUTH:
                return "THE_GOSPEL_OF_TRUTH";
            case Titles.MEDITATIONS:
                return "MEDITATIONS";
            case Titles.OUTLINES_OF_PYRRHONISM:
                return "OUTLINES_OF_PYRRHONISM";
            case Titles.ENNEADS:
                return "ENNEADS";
            case Titles.CONFESSIONS:
                return "CONFESSIONS";
            case Titles.THE_KORAN:
                return "THE_KORAN";
            case Titles.GUIDE_FOR_THE_PERPLEXED:
                return "GUIDE_FOR_THE_PERPLEXED";
            case Titles.THE_KABBALAH:
                return "THE_KABBALAH";
            case Titles.SUMMA_THEOLOGICAE:
                return "SUMMA_THEOLOGICAE";
            case Titles.THE_DIVINE_COMEDY:
                return "THE_DIVINE_COMEDY";
            case Titles.IN_PRAISE_OF_FOLLY:
                return "IN_PRAISE_OF_FOLLY";
            case Titles.THE_PRINCE:
                return "THE_PRINCE";
            case Titles.ON_THE_BABYLONIAN_CAPTIVITY_OF_THE_CHURCH:
                return "ON_THE_BABYLONIAN_CAPTIVITY_OF_THE_CHURCH";
            case Titles.GARGANTUA_AND_PANTAGRUEL:
                return "GARGANTUA_AND_PANTAGRUEL";
            case Titles.INSTITUTES_OF_THE_CHRISTIAN_RELIGION:
                return "INSTITUTES_OF_THE_CHRISTIAN_RELIGION";
            case Titles.ON_THE_REVOLUTION_OF_THE_CELESTIAL_ORBS:
                return "ON_THE_REVOLUTION_OF_THE_CELESTIAL_ORBS";
            case Titles.ESSAYS:
                return "ESSAYS";
            case Titles.DON_QUIXOTE:
                return "DON_QUIXOTE";
            case Titles.THE_HARMONY_OF_THE_WORLD:
                return "THE_HARMONY_OF_THE_WORLD";
            case Titles.NOVUM_ORGANUM:
                return "NOVUM_ORGANUM";
            case Titles.THE_FIRST_FOLIO:
                return "THE_FIRST_FOLIO";
            case Titles.DIALOGUE_CONCERNING_TWO_NEW_CHIEF_WORLD_SYSTEMS:
                return "DIALOGUE_CONCERNING_TWO_NEW_CHIEF_WORLD_SYSTEMS";
            case Titles.DISCOURSE_ON_METHOD:
                return "DISCOURSE_ON_METHOD";
            case Titles.LEVIATHAN:
                return "LEVIATHAN";
            case Titles.PENSEES:
                return "PENSEES";
            case Titles.ETHICS:
                return "ETHICS";
            case Titles.PILGRIM_S_PROGRESS:
                return "PILGRIM_S_PROGRESS";
            case Titles.MATHEMATICAL_PRINCIPLES_OF_NATURAL_PHILOSOPHY:
                return "MATHEMATICAL_PRINCIPLES_OF_NATURAL_PHILOSOPHY";
            case Titles.ESSAY_CONCERNING_HUMAN_UNDERSTANDING:
                return "ESSAY_CONCERNING_HUMAN_UNDERSTANDING";
            case Titles.THE_PRINCIPLES_OF_HUMAN_KNOWLEDGE:
                return "THE_PRINCIPLES_OF_HUMAN_KNOWLEDGE";
            case Titles.THE_NEW_SCIENCE:
                return "THE_NEW_SCIENCE";
            case Titles.A_TREATISE_OF_HUMAN_NATURE:
                return "A_TREATISE_OF_HUMAN_NATURE";
            case Titles.THE_ENCYCLOPEDIA:
                return "THE_ENCYCLOPEDIA";
            case Titles.A_DICTIONARY_OF_THE_ENGLISH_LANGUAGE:
                return "A_DICTIONARY_OF_THE_ENGLISH_LANGUAGE";
            case Titles.CANDIDE:
                return "CANDIDE";
            case Titles.COMMON_SENSE:
                return "COMMON_SENSE";
            case Titles.AN_ENQUIRY_INTO_THE_NATURE_AND_CAUSES_OF_THE_WEALTH_OF_NATIONS:
                return "AN_ENQUIRY_INTO_THE_NATURE_AND_CAUSES_OF_THE_WEALTH_OF_NATIONS";
            case Titles.THE_HISTORY_OF_THE_DECLINE_AND_FALL_OF_THE_ROMAN_EMPIRE:
                return "THE_HISTORY_OF_THE_DECLINE_AND_FALL_OF_THE_ROMAN_EMPIRE";
            case Titles.CRITIQUE_OF_PURE_REASON:
                return "CRITIQUE_OF_PURE_REASON";
            case Titles.CONFESSIONSJACQUES_ROUSSEAU:
                return "CONFESSIONSJACQUES_ROUSSEAU";
            case Titles.REFLECTIONS_ON_THE_REVOLUTION_IN_FRANCE:
                return "REFLECTIONS_ON_THE_REVOLUTION_IN_FRANCE";
            case Titles.VINDICATION_OF_THE_RIGHTS_OF_WOMEN:
                return "VINDICATION_OF_THE_RIGHTS_OF_WOMEN";
            case Titles.AN_ENQUIRY_CONCERNING_POLITICAL_JUSTICE:
                return "AN_ENQUIRY_CONCERNING_POLITICAL_JUSTICE";
            case Titles.AN_ESSAY_ON_THE_PRINCIPLE_OF_POPULATION:
                return "AN_ESSAY_ON_THE_PRINCIPLE_OF_POPULATION";
            case Titles.PHENOMENOLOGY_OF_SPIRIT:
                return "PHENOMENOLOGY_OF_SPIRIT";
            case Titles.THE_WORLD_AS_WILL_AND_IDEA:
                return "THE_WORLD_AS_WILL_AND_IDEA";
            case Titles.COURSE_IN_THE_POSITIVIST_PHILOSOPHY:
                return "COURSE_IN_THE_POSITIVIST_PHILOSOPHY";
            case Titles.ON_WAR:
                return "ON_WAR";
            case Titles.EITHER_OR:
                return "EITHER_OR";
            case Titles.THE_MANIFESTO_OF_THE_COMMUNIST_PARTY:
                return "THE_MANIFESTO_OF_THE_COMMUNIST_PARTY";
            case Titles.CIVIL_DISOBEDIENCE:
                return "CIVIL_DISOBEDIENCE";
            case Titles.THE_ORIGIN_OF_SPECIES_BY_MEANS_OF_NATURAL_SELECTION:
                return "THE_ORIGIN_OF_SPECIES_BY_MEANS_OF_NATURAL_SELECTION";
            case Titles.ON_LIBERTY:
                return "ON_LIBERTY";
            case Titles.FIRST_PRINCIPLES:
                return "FIRST_PRINCIPLES";
            case Titles.EXPERIMENTS_WITH_PLANT_HYBRIDS_MENDEL:
                return "EXPERIMENTS_WITH_PLANT_HYBRIDS_MENDEL";
            case Titles.WAR_AND_PEACE:
                return "WAR_AND_PEACE";
            case Titles.TREATISE_ON_ELECTRICITY_AND_MAGNETISM_MAXWELL:
                return "TREATISE_ON_ELECTRICITY_AND_MAGNETISM_MAXWELL";
            case Titles.THUS_SPAKE_ZARATHUSTRA:
                return "THUS_SPAKE_ZARATHUSTRA";
            case Titles.THE_INTERPRETATION_OF_DREAMS:
                return "THE_INTERPRETATION_OF_DREAMS";
            case Titles.PRAGMATISM:
                return "PRAGMATISM";
            case Titles.RELATIVITY:
                return "RELATIVITY";
            case Titles.THE_MIND_AND_SOCIETY:
                return "THE_MIND_AND_SOCIETY";
            case Titles.PSYCHOLOGICAL_TYPES:
                return "PSYCHOLOGICAL_TYPES";
            case Titles.I_AND_THOU:
                return "I_AND_THOU";
            case Titles.THE_TRIAL:
                return "THE_TRIAL";
            case Titles.THE_LOGIC_OF_SCIENTIFIC_DISCOVERY:
                return "THE_LOGIC_OF_SCIENTIFIC_DISCOVERY";
            case Titles.THE_GENERAL_THEORY_OF_EMPLOYMENT:
                return "THE_GENERAL_THEORY_OF_EMPLOYMENT";
            case Titles.BEING_AND_NOTHINGNESS:
                return "BEING_AND_NOTHINGNESS";
            case Titles.THE_ROAD_TO_SERFDOM:
                return "THE_ROAD_TO_SERFDOM";
            case Titles.THE_SECOND_SEX:
                return "THE_SECOND_SEX";
            case Titles.CYBERNETICS:
                return "CYBERNETICS";
            case Titles.NINETEEN_EIGHTY_FOUR:
                return "NINETEEN_EIGHTY_FOUR";
            case Titles.BEELZEBUB_S_TALES_TO_HIS_GRANDSON:
                return "BEELZEBUB_S_TALES_TO_HIS_GRANDSON";
            case Titles.PHILOSOPHICAL_INVESTIGATIONS:
                return "PHILOSOPHICAL_INVESTIGATIONS";
            case Titles.SYNTACTIC_STRUCTURES:
                return "SYNTACTIC_STRUCTURES";
            case Titles.THE_STRUCTURE_OF_SCIENTIFIC_REVOLUTIONS:
                return "THE_STRUCTURE_OF_SCIENTIFIC_REVOLUTIONS";
            case Titles.THE_FEMININE_MYSTIQUE:
                return "THE_FEMININE_MYSTIQUE";
            case Titles.QUOTATIONS_FROM_CHAIRMAN_MAO_TSE_TUNG:
                return "QUOTATIONS_FROM_CHAIRMAN_MAO_TSE_TUNG";
            default:
                throw new ArgumentOutOfRangeException("inncorrect book name");
        }
    }
}